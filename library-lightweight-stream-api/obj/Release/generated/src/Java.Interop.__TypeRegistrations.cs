using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/annimon/stream/function",
					},
					new Converter<string, Type>[]{
						lookup_com_annimon_stream_function_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_annimon_stream_function_mappings;
		static Type lookup_com_annimon_stream_function_package (string klass)
		{
			if (package_com_annimon_stream_function_mappings == null) {
				package_com_annimon_stream_function_mappings = new string[]{
					"com/annimon/stream/function/BiConsumer$Util:Com.Annimon.Stream.Function.BiConsumerUtil",
					"com/annimon/stream/function/BiFunction$Util:Com.Annimon.Stream.Function.BiFunctionUtil",
					"com/annimon/stream/function/BinaryOperator$Util:Com.Annimon.Stream.Function.BinaryOperatorUtil",
					"com/annimon/stream/function/BooleanConsumer$Util:Com.Annimon.Stream.Function.BooleanConsumerUtil",
					"com/annimon/stream/function/BooleanPredicate$Util:Com.Annimon.Stream.Function.BooleanPredicateUtil",
					"com/annimon/stream/function/Consumer$Util:Com.Annimon.Stream.Function.ConsumerUtil",
					"com/annimon/stream/function/DoubleConsumer$Util:Com.Annimon.Stream.Function.DoubleConsumerUtil",
					"com/annimon/stream/function/DoubleFunction$Util:Com.Annimon.Stream.Function.DoubleFunctionUtil",
					"com/annimon/stream/function/DoublePredicate$Util:Com.Annimon.Stream.Function.DoublePredicateUtil",
					"com/annimon/stream/function/DoubleSupplier$Util:Com.Annimon.Stream.Function.DoubleSupplierUtil",
					"com/annimon/stream/function/DoubleUnaryOperator$Util:Com.Annimon.Stream.Function.DoubleUnaryOperatorUtil",
					"com/annimon/stream/function/Function$Util:Com.Annimon.Stream.Function.FunctionUtil",
					"com/annimon/stream/function/IndexedBiFunction$Util:Com.Annimon.Stream.Function.IndexedBiFunctionUtil",
					"com/annimon/stream/function/IndexedConsumer$Util:Com.Annimon.Stream.Function.IndexedConsumerUtil",
					"com/annimon/stream/function/IndexedDoubleConsumer$Util:Com.Annimon.Stream.Function.IndexedDoubleConsumerUtil",
					"com/annimon/stream/function/IndexedDoubleFunction$Util:Com.Annimon.Stream.Function.IndexedDoubleFunctionUtil",
					"com/annimon/stream/function/IndexedDoublePredicate$Util:Com.Annimon.Stream.Function.IndexedDoublePredicateUtil",
					"com/annimon/stream/function/IndexedDoubleUnaryOperator$Util:Com.Annimon.Stream.Function.IndexedDoubleUnaryOperatorUtil",
					"com/annimon/stream/function/IndexedFunction$Util:Com.Annimon.Stream.Function.IndexedFunctionUtil",
					"com/annimon/stream/function/IndexedIntConsumer$Util:Com.Annimon.Stream.Function.IndexedIntConsumerUtil",
					"com/annimon/stream/function/IndexedIntFunction$Util:Com.Annimon.Stream.Function.IndexedIntFunctionUtil",
					"com/annimon/stream/function/IndexedIntPredicate$Util:Com.Annimon.Stream.Function.IndexedIntPredicateUtil",
					"com/annimon/stream/function/IndexedLongConsumer$Util:Com.Annimon.Stream.Function.IndexedLongConsumerUtil",
					"com/annimon/stream/function/IndexedLongFunction$Util:Com.Annimon.Stream.Function.IndexedLongFunctionUtil",
					"com/annimon/stream/function/IndexedLongPredicate$Util:Com.Annimon.Stream.Function.IndexedLongPredicateUtil",
					"com/annimon/stream/function/IndexedLongUnaryOperator$Util:Com.Annimon.Stream.Function.IndexedLongUnaryOperatorUtil",
					"com/annimon/stream/function/IndexedPredicate$Util:Com.Annimon.Stream.Function.IndexedPredicateUtil",
					"com/annimon/stream/function/IntConsumer$Util:Com.Annimon.Stream.Function.IntConsumerUtil",
					"com/annimon/stream/function/IntFunction$Util:Com.Annimon.Stream.Function.IntFunctionUtil",
					"com/annimon/stream/function/IntPredicate$Util:Com.Annimon.Stream.Function.IntPredicateUtil",
					"com/annimon/stream/function/IntSupplier$Util:Com.Annimon.Stream.Function.IntSupplierUtil",
					"com/annimon/stream/function/IntUnaryOperator$Util:Com.Annimon.Stream.Function.IntUnaryOperatorUtil",
					"com/annimon/stream/function/LongConsumer$Util:Com.Annimon.Stream.Function.LongConsumerUtil",
					"com/annimon/stream/function/LongFunction$Util:Com.Annimon.Stream.Function.LongFunctionUtil",
					"com/annimon/stream/function/LongPredicate$Util:Com.Annimon.Stream.Function.LongPredicateUtil",
					"com/annimon/stream/function/LongSupplier$Util:Com.Annimon.Stream.Function.LongSupplierUtil",
					"com/annimon/stream/function/LongUnaryOperator$Util:Com.Annimon.Stream.Function.LongUnaryOperatorUtil",
					"com/annimon/stream/function/Predicate$Util:Com.Annimon.Stream.Function.PredicateUtil",
					"com/annimon/stream/function/Supplier$Util:Com.Annimon.Stream.Function.SupplierUtil",
					"com/annimon/stream/function/UnaryOperator$Util:Com.Annimon.Stream.Function.UnaryOperatorUtil",
				};
			}

			return Lookup (package_com_annimon_stream_function_mappings, klass);
		}
	}
}
