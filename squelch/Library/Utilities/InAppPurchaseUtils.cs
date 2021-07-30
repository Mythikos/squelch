using Plugin.InAppBilling;
using System;
using System.Threading.Tasks;

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
        public static async Task<PurchaseResult> PurchaseAsync(string productId, bool shouldConsume = true)
        {
            bool connected = false;
            bool consumed = false;
            IInAppBilling billing;
            InAppBillingPurchase purchase;
            PurchaseResult result;

            //
            // Get current billing interface
            billing = CrossInAppBilling.Current;

            try
            {
                //
                // Connect to the payment service
                connected = await billing.ConnectAsync();
                if (connected)
                {
                    //
                    // Attempt the purchase
                    purchase = await billing.PurchaseAsync(productId, ItemType.InAppPurchase);
                    if (purchase != null)
                    {
                        //
                        // Consume the purchase if we need to
                        if (shouldConsume)
                        {
                            consumed = await billing.ConsumePurchaseAsync(productId, purchase.PurchaseToken);
                            if (consumed == true)
                            {
                                result = new PurchaseResult(true, Resource.String.inapppurchaseutils_purchase_was_successful);
                            }
                            else
                            {
                                result = new PurchaseResult(false, Resource.String.inapppurchaseutils_purchase_was_successful_but_could_not_consume);
                            }
                        }
                        else
                        {
                            result = new PurchaseResult(true, Resource.String.inapppurchaseutils_purchase_was_successful);
                        }
                    }
                    else
                    {
                        result = new PurchaseResult(false, Resource.String.inapppurchaseutils_purchase_was_not_successful);
                    }
                }
                else
                {
                    result = new PurchaseResult(false, Resource.String.inapppurchaseutils_unable_to_connect);
                }
            }
            catch (InAppBillingPurchaseException ex)
            {
                if (ex != null)
                {
                    if (ex.PurchaseError == PurchaseError.UserCancelled)
                    {
                        result = new PurchaseResult(false, Resource.String._blank);
                    }
                    // Was the purchase already made?
                    else if (ex.PurchaseError == PurchaseError.AlreadyOwned)
                    {
                        // Do we want to consume this purchase?
                        if (shouldConsume)
                        {
                            if (!connected)
                            {
                                connected = await billing.ConnectAsync();
                            }

                            // Are we still connected?
                            if (connected)
                            {
                                consumed = false;

                                // Get all purchases
                                System.Collections.Generic.IEnumerable<InAppBillingPurchase> previousPurchases = await CrossInAppBilling.Current.GetPurchasesAsync(ItemType.InAppPurchase);
                                foreach (InAppBillingPurchase previousPurchase in previousPurchases)
                                {
                                    // Find the unconsumed purchase of this product
                                    if (previousPurchase.ProductId.Equals(productId) && previousPurchase.ConsumptionState == ConsumptionState.NoYetConsumed)
                                    {
                                        // Consume it
                                        consumed = await billing.ConsumePurchaseAsync(productId, previousPurchase.PurchaseToken);
                                        if (consumed == true)
                                        {
                                            break;
                                        }
                                    }
                                }

                                // Check consumption
                                if (consumed == true)
                                {
                                    result = new PurchaseResult(true, Resource.String.inapppurchaseutils_purchase_was_successful);
                                }
                                else
                                {
                                    result = new PurchaseResult(false, Resource.String.inapppurchaseutils_unable_to_consume);
                                }
                            }
                            else
                            {
                                result = new PurchaseResult(false, Resource.String.inapppurchaseutils_unable_to_connect);
                            }
                        }
                        else
                        {
                            Logger.Write(s_tag, $"PurchaseAsync: {Logger.CreateExceptionString(ex)}", Logger.Severity.Warn);
                            result = new PurchaseResult(true, Resource.String.inapppurchaseutils_item_already_owned);
                        }
                    }
                    else
                    {
                        Logger.Write(s_tag, $"PurchaseAsync: {ex.PurchaseError.ToString()}: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
                        result = new PurchaseResult(false, Resource.String.error_unexpected_error_occured);
                    }
                }
                else
                {
                    Logger.Write(s_tag, $"PurchaseAsync: Exception variable was received by catch as null", Logger.Severity.Error);
                    result = new PurchaseResult(false, Resource.String.error_unexpected_error_occured);
                }
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"PurchaseAsync: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
                result = new PurchaseResult(false, Resource.String.error_unexpected_error_occured);
            }
            finally
            {
                //
                // Disconnect from the payment service
                await billing.DisconnectAsync();
            }

            return result;
        }

        #region Internal Classes
        internal class PurchaseResult
        {
            public bool Successful { get; set; }
            public int MessageResourceId { get; set; }

            public PurchaseResult()
            {
                this.Successful = false;
                this.MessageResourceId = 0;
            }

            public PurchaseResult(bool successful, int messageResourceId)
            {
                this.Successful = successful;
                this.MessageResourceId = messageResourceId;
            }
        }
        #endregion
    }
}