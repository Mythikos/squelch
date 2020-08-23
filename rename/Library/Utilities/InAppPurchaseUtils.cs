using System;
using System.Threading.Tasks;
using Plugin.InAppBilling;
using Plugin.InAppBilling.Abstractions;

namespace Squelch.Library.Utilities
{
    internal static class InAppPurchaseUtils
    {
        #region Instance Variables
        private static readonly string s_tag = typeof(InAppPurchaseUtils).FullName;
        #endregion

        /// <summary>
        /// Processes the purchase of the provided product id, consuming an existing purchase if required
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="shouldConsume"></param>
        /// <returns>(result, resultMessage)</returns>
        public static async Task<(bool, string)> PurchaseAsync(string productId, bool shouldConsume = true)
        {
            bool connected = false;
            IInAppBilling billing;
            InAppBillingPurchase purchase;
            InAppBillingPurchase consumedPurchased;
            (bool, string) result;

            //
            // Get current billing interface
            billing = CrossInAppBilling.Current;

            try
            {
                //
                // Connect to the payment service
                connected = await billing.ConnectAsync(ItemType.InAppPurchase);
                if (connected)
                {
                    //
                    // Attempt the purchase
                    purchase = await billing.PurchaseAsync(productId, ItemType.InAppPurchase, "squelch_payload");
                    if (purchase != null)
                    {
                        //
                        // Consume the purchase if we need to
                        if (shouldConsume)
                        {
                            consumedPurchased = await billing.ConsumePurchaseAsync(productId, purchase.PurchaseToken);
                            if (consumedPurchased != null)
                            {
                                if (consumedPurchased.ConsumptionState == ConsumptionState.Consumed)
                                {
                                    result = (true, "Purchase was successful!");
                                }
                                else
                                {
                                    result = (false, "Purchase was successful but could not be consumed.");
                                }
                            }
                            else
                            {
                                result = (false, "Purchase was successful but could not be consumed.");
                            }
                        }
                        else
                        {
                            result = (true, "Purchase was successful!");
                        }
                    }
                    else
                    {
                        result = (false, "Purchase was not successful.");
                    }
                }
                else
                {
                    result = (false, "Unable to connect to payment service.");
                }
            }
            catch (InAppBillingPurchaseException ex)
            {
                if (ex != null)
                {
                    if (ex.PurchaseError == PurchaseError.UserCancelled)
                    {
                        result = (false, string.Empty);
                    }
                    // Was the purchase already made?
                    else if (ex.PurchaseError == PurchaseError.AlreadyOwned)
                    {
                        // Do we want to consume this purchase?
                        if (shouldConsume)
                        {
                            if (!connected)
                                connected = await billing.ConnectAsync(ItemType.InAppPurchase);

                            // Are we still connected?
                            if (connected)
                            {
                                consumedPurchased = null;

                                // Get all purchases
                                var previousPurchases = await CrossInAppBilling.Current.GetPurchasesAsync(ItemType.InAppPurchase);
                                foreach (InAppBillingPurchase previousPurchase in previousPurchases)
                                {
                                    // Find the unconsumed purchase of this product
                                    if (previousPurchase.ProductId.Equals(productId) && previousPurchase.ConsumptionState == ConsumptionState.NoYetConsumed)
                                    {
                                        // Consume it
                                        consumedPurchased = await billing.ConsumePurchaseAsync(productId, previousPurchase.PurchaseToken);
                                        if (consumedPurchased.ConsumptionState == ConsumptionState.Consumed)
                                            break;
                                    }
                                }

                                // Check consumption
                                if (consumedPurchased != null)
                                {
                                    if (consumedPurchased.ConsumptionState == ConsumptionState.Consumed)
                                    {
                                        result = (true, "Purchase was successful!");
                                    }
                                    else
                                    {
                                        result = (false, "Purchase is marked as already owned but it couldn't be consumed.");
                                    }
                                }
                                else
                                {
                                    result = (false, "Unable to consume the purchase.");
                                }
                            }
                            else
                            {
                                result = (false, "Not connected to payment service. Please try again later.");
                            }
                        }
                        else
                        {
                            Logger.Write(s_tag, $"PurchaseAsync: {Logger.CreateExceptionString(ex)}", Logger.Severity.Warn);
                            result = (true, "You already own this item.");
                        }
                    }
                    else
                    {
                        Logger.Write(s_tag, $"PurchaseAsync: {ex.PurchaseError.ToString()}: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
                        result = (false, "An unexpected error has occured. Please try again later.");
                    }
                }
                else
                {
                    Logger.Write(s_tag, $"PurchaseAsync: Exception variable was received by catch as null", Logger.Severity.Error);
                    result = (false, "An unexpected error has occured. Please try again later.");
                }
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"PurchaseAsync: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
                result = (false, "An unexpected error has occured. Please try again later.");
            }
            finally
            {
                //
                // Disconnect from the payment service
                await billing.DisconnectAsync();
            }

            return result;
        }
    }
}