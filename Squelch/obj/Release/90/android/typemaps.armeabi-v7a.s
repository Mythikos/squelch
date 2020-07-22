	.arch	armv7-a
	.syntax unified
	.eabi_attribute 67, "2.09"	@ Tag_conformance
	.eabi_attribute 6, 10	@ Tag_CPU_arch
	.eabi_attribute 7, 65	@ Tag_CPU_arch_profile
	.eabi_attribute 8, 1	@ Tag_ARM_ISA_use
	.eabi_attribute 9, 2	@ Tag_THUMB_ISA_use
	.fpu	vfpv3-d16
	.eabi_attribute 34, 1	@ Tag_CPU_unaligned_access
	.eabi_attribute 15, 1	@ Tag_ABI_PCS_RW_data
	.eabi_attribute 16, 1	@ Tag_ABI_PCS_RO_data
	.eabi_attribute 17, 2	@ Tag_ABI_PCS_GOT_use
	.eabi_attribute 20, 2	@ Tag_ABI_FP_denormal
	.eabi_attribute 21, 0	@ Tag_ABI_FP_exceptions
	.eabi_attribute 23, 3	@ Tag_ABI_FP_number_model
	.eabi_attribute 24, 1	@ Tag_ABI_align_needed
	.eabi_attribute 25, 1	@ Tag_ABI_align_preserved
	.eabi_attribute 38, 1	@ Tag_ABI_FP_16bit_format
	.eabi_attribute 18, 4	@ Tag_ABI_PCS_wchar_t
	.eabi_attribute 26, 2	@ Tag_ABI_enum_size
	.eabi_attribute 14, 0	@ Tag_ABI_PCS_R9_use
	.file	"typemaps.armeabi-v7a.s"

/* map_module_count: START */
	.section	.rodata.map_module_count,"a",%progbits
	.type	map_module_count, %object
	.p2align	2
	.global	map_module_count
map_module_count:
	.size	map_module_count, 4
	.long	24
/* map_module_count: END */

/* java_type_count: START */
	.section	.rodata.java_type_count,"a",%progbits
	.type	java_type_count, %object
	.p2align	2
	.global	java_type_count
java_type_count:
	.size	java_type_count, 4
	.long	489
/* java_type_count: END */

/* java_name_width: START */
	.section	.rodata.java_name_width,"a",%progbits
	.type	java_name_width, %object
	.p2align	2
	.global	java_name_width
java_name_width:
	.size	java_name_width, 4
	.long	117
/* java_name_width: END */

	.include	"typemaps.armeabi-v7a-shared.inc"
	.include	"typemaps.armeabi-v7a-managed.inc"

/* Managed to Java map: START */
	.section	.data.rel.map_modules,"aw",%progbits
	.type	map_modules, %object
	.p2align	2
	.global	map_modules
map_modules:
	/* module_uuid: 9bae190f-3150-4bc2-8b48-ed7557c67675 */
	.byte	0x0f, 0x19, 0xae, 0x9b, 0x50, 0x31, 0xc2, 0x4b, 0x8b, 0x48, 0xed, 0x75, 0x57, 0xc6, 0x76, 0x75
	/* entry_count */
	.long	1
	/* duplicate_count */
	.long	0
	/* map */
	.long	module0_managed_to_java
	/* duplicate_map */
	.long	0
	/* assembly_name: Xamarin.GooglePlayServices.Measurement.Api */
	.long	.L.map_aname.0
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 4899ad11-6dc5-4c49-bc25-1d5332f6587e */
	.byte	0x11, 0xad, 0x99, 0x48, 0xc5, 0x6d, 0x49, 0x4c, 0xbc, 0x25, 0x1d, 0x53, 0x32, 0xf6, 0x58, 0x7e
	/* entry_count */
	.long	3
	/* duplicate_count */
	.long	1
	/* map */
	.long	module1_managed_to_java
	/* duplicate_map */
	.long	module1_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.CoordinatorLayout */
	.long	.L.map_aname.1
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 59210923-e675-48cc-8553-14c494ef79f6 */
	.byte	0x23, 0x09, 0x21, 0x59, 0x75, 0xe6, 0xcc, 0x48, 0x85, 0x53, 0x14, 0xc4, 0x94, 0xef, 0x79, 0xf6
	/* entry_count */
	.long	1
	/* duplicate_count */
	.long	0
	/* map */
	.long	module2_managed_to_java
	/* duplicate_map */
	.long	0
	/* assembly_name: Plugin.CurrentActivity */
	.long	.L.map_aname.2
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 2f0bf323-1637-421b-b4b3-90d36e2e2844 */
	.byte	0x23, 0xf3, 0x0b, 0x2f, 0x37, 0x16, 0x1b, 0x42, 0xb4, 0xb3, 0x90, 0xd3, 0x6e, 0x2e, 0x28, 0x44
	/* entry_count */
	.long	4
	/* duplicate_count */
	.long	1
	/* map */
	.long	module3_managed_to_java
	/* duplicate_map */
	.long	module3_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Lifecycle.Common */
	.long	.L.map_aname.3
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 84e66c33-ad57-4ee2-a51b-3725b23603cf */
	.byte	0x33, 0x6c, 0xe6, 0x84, 0x57, 0xad, 0xe2, 0x4e, 0xa5, 0x1b, 0x37, 0x25, 0xb2, 0x36, 0x03, 0xcf
	/* entry_count */
	.long	1
	/* duplicate_count */
	.long	0
	/* map */
	.long	module4_managed_to_java
	/* duplicate_map */
	.long	0
	/* assembly_name: Xamarin.AndroidX.CardView */
	.long	.L.map_aname.4
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 4a8f2f38-ee52-4322-9d49-42667a03a953 */
	.byte	0x38, 0x2f, 0x8f, 0x4a, 0x52, 0xee, 0x22, 0x43, 0x9d, 0x49, 0x42, 0x66, 0x7a, 0x03, 0xa9, 0x53
	/* entry_count */
	.long	4
	/* duplicate_count */
	.long	1
	/* map */
	.long	module5_managed_to_java
	/* duplicate_map */
	.long	module5_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Activity */
	.long	.L.map_aname.5
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 37623947-4296-483f-8cfb-2f42a21f7151 */
	.byte	0x47, 0x39, 0x62, 0x37, 0x96, 0x42, 0x3f, 0x48, 0x8c, 0xfb, 0x2f, 0x42, 0xa2, 0x1f, 0x71, 0x51
	/* entry_count */
	.long	317
	/* duplicate_count */
	.long	50
	/* map */
	.long	module6_managed_to_java
	/* duplicate_map */
	.long	module6_managed_to_java_duplicates
	/* assembly_name: Mono.Android */
	.long	.L.map_aname.6
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: b8627756-58ee-4fd3-84ab-d2ba48d53241 */
	.byte	0x56, 0x77, 0x62, 0xb8, 0xee, 0x58, 0xd3, 0x4f, 0x84, 0xab, 0xd2, 0xba, 0x48, 0xd5, 0x32, 0x41
	/* entry_count */
	.long	46
	/* duplicate_count */
	.long	3
	/* map */
	.long	module7_managed_to_java
	/* duplicate_map */
	.long	module7_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Core */
	.long	.L.map_aname.7
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 319f7f57-3896-4191-a3b8-8abf70f5e4a5 */
	.byte	0x57, 0x7f, 0x9f, 0x31, 0x96, 0x38, 0x91, 0x41, 0xa3, 0xb8, 0x8a, 0xbf, 0x70, 0xf5, 0xe4, 0xa5
	/* entry_count */
	.long	2
	/* duplicate_count */
	.long	0
	/* map */
	.long	module8_managed_to_java
	/* duplicate_map */
	.long	0
	/* assembly_name: Xamarin.Essentials */
	.long	.L.map_aname.8
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 9a1b995c-f090-4cbe-a0e6-49af835841cf */
	.byte	0x5c, 0x99, 0x1b, 0x9a, 0x90, 0xf0, 0xbe, 0x4c, 0xa0, 0xe6, 0x49, 0xaf, 0x83, 0x58, 0x41, 0xcf
	/* entry_count */
	.long	11
	/* duplicate_count */
	.long	3
	/* map */
	.long	module9_managed_to_java
	/* duplicate_map */
	.long	module9_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Fragment */
	.long	.L.map_aname.9
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 2322745d-f0a8-4f26-8de2-64b2bd4e192d */
	.byte	0x5d, 0x74, 0x22, 0x23, 0xa8, 0xf0, 0x26, 0x4f, 0x8d, 0xe2, 0x64, 0xb2, 0xbd, 0x4e, 0x19, 0x2d
	/* entry_count */
	.long	3
	/* duplicate_count */
	.long	0
	/* map */
	.long	module10_managed_to_java
	/* duplicate_map */
	.long	0
	/* assembly_name: Xamarin.AndroidX.DrawerLayout */
	.long	.L.map_aname.10
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: c57c3374-06aa-4c11-ba3b-a087a28f636a */
	.byte	0x74, 0x33, 0x7c, 0xc5, 0xaa, 0x06, 0x11, 0x4c, 0xba, 0x3b, 0xa0, 0x87, 0xa2, 0x8f, 0x63, 0x6a
	/* entry_count */
	.long	2
	/* duplicate_count */
	.long	1
	/* map */
	.long	module11_managed_to_java
	/* duplicate_map */
	.long	module11_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.VersionedParcelable */
	.long	.L.map_aname.11
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 7b118c77-2058-4a89-b4c5-f6f2d09c4cfc */
	.byte	0x77, 0x8c, 0x11, 0x7b, 0x58, 0x20, 0x89, 0x4a, 0xb4, 0xc5, 0xf6, 0xf2, 0xd0, 0x9c, 0x4c, 0xfc
	/* entry_count */
	.long	2
	/* duplicate_count */
	.long	1
	/* map */
	.long	module12_managed_to_java
	/* duplicate_map */
	.long	module12_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Lifecycle.LiveData.Core */
	.long	.L.map_aname.12
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: c43ef682-152e-4118-a8b7-da1f25d1204b */
	.byte	0x82, 0xf6, 0x3e, 0xc4, 0x2e, 0x15, 0x18, 0x41, 0xa8, 0xb7, 0xda, 0x1f, 0x25, 0xd1, 0x20, 0x4b
	/* entry_count */
	.long	13
	/* duplicate_count */
	.long	0
	/* map */
	.long	module13_managed_to_java
	/* duplicate_map */
	.long	0
	/* assembly_name: Squelch */
	.long	.L.map_aname.13
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 1e279a83-e238-4729-a628-55710bec57f8 */
	.byte	0x83, 0x9a, 0x27, 0x1e, 0x38, 0xe2, 0x29, 0x47, 0xa6, 0x28, 0x55, 0x71, 0x0b, 0xec, 0x57, 0xf8
	/* entry_count */
	.long	3
	/* duplicate_count */
	.long	0
	/* map */
	.long	module14_managed_to_java
	/* duplicate_map */
	.long	0
	/* assembly_name: Xamarin.AndroidX.SavedState */
	.long	.L.map_aname.14
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 0ba5b886-07ed-49d0-8982-96621ce56c3d */
	.byte	0x86, 0xb8, 0xa5, 0x0b, 0xed, 0x07, 0xd0, 0x49, 0x89, 0x82, 0x96, 0x62, 0x1c, 0xe5, 0x6c, 0x3d
	/* entry_count */
	.long	32
	/* duplicate_count */
	.long	4
	/* map */
	.long	module15_managed_to_java
	/* duplicate_map */
	.long	module15_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.AppCompat */
	.long	.L.map_aname.15
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 2be3ca88-0762-42b5-875e-211410fe2dd3 */
	.byte	0x88, 0xca, 0xe3, 0x2b, 0x62, 0x07, 0xb5, 0x42, 0x87, 0x5e, 0x21, 0x14, 0x10, 0xfe, 0x2d, 0xd3
	/* entry_count */
	.long	1
	/* duplicate_count */
	.long	0
	/* map */
	.long	module16_managed_to_java
	/* duplicate_map */
	.long	0
	/* assembly_name: Plugin.InAppBilling */
	.long	.L.map_aname.16
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: aad70e8e-c42d-40a5-a7db-7659672c5a08 */
	.byte	0x8e, 0x0e, 0xd7, 0xaa, 0x2d, 0xc4, 0xa5, 0x40, 0xa7, 0xdb, 0x76, 0x59, 0x67, 0x2c, 0x5a, 0x08
	/* entry_count */
	.long	11
	/* duplicate_count */
	.long	2
	/* map */
	.long	module17_managed_to_java
	/* duplicate_map */
	.long	module17_managed_to_java_duplicates
	/* assembly_name: Xamarin.GooglePlayServices.Tasks */
	.long	.L.map_aname.17
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 98922c9b-781e-4516-9373-1daf2f341399 */
	.byte	0x9b, 0x2c, 0x92, 0x98, 0x1e, 0x78, 0x16, 0x45, 0x93, 0x73, 0x1d, 0xaf, 0x2f, 0x34, 0x13, 0x99
	/* entry_count */
	.long	2
	/* duplicate_count */
	.long	0
	/* map */
	.long	module18_managed_to_java
	/* duplicate_map */
	.long	0
	/* assembly_name: Xamarin.AndroidX.Lifecycle.ViewModel */
	.long	.L.map_aname.18
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: d25befab-bad2-48a0-b45b-b9fd0dd4eb8c */
	.byte	0xab, 0xef, 0x5b, 0xd2, 0xd2, 0xba, 0xa0, 0x48, 0xb4, 0x5b, 0xb9, 0xfd, 0x0d, 0xd4, 0xeb, 0x8c
	/* entry_count */
	.long	6
	/* duplicate_count */
	.long	0
	/* map */
	.long	module19_managed_to_java
	/* duplicate_map */
	.long	0
	/* assembly_name: Xamarin.Google.AutoValue.Annotations */
	.long	.L.map_aname.19
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 5cf4ccd7-6f67-4b45-b3be-a7ba37ba0b38 */
	.byte	0xd7, 0xcc, 0xf4, 0x5c, 0x67, 0x6f, 0x45, 0x4b, 0xb3, 0xbe, 0xa7, 0xba, 0x37, 0xba, 0x0b, 0x38
	/* entry_count */
	.long	2
	/* duplicate_count */
	.long	0
	/* map */
	.long	module20_managed_to_java
	/* duplicate_map */
	.long	0
	/* assembly_name: Plugin.InAppBilling.VendingLibrary */
	.long	.L.map_aname.20
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 22ab85d9-c40c-4739-b6fe-c7ac6cfd022e */
	.byte	0xd9, 0x85, 0xab, 0x22, 0x0c, 0xc4, 0x39, 0x47, 0xb6, 0xfe, 0xc7, 0xac, 0x6c, 0xfd, 0x02, 0x2e
	/* entry_count */
	.long	1
	/* duplicate_count */
	.long	0
	/* map */
	.long	module21_managed_to_java
	/* duplicate_map */
	.long	0
	/* assembly_name: Xamarin.Google.Guava.ListenableFuture */
	.long	.L.map_aname.21
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: f54a74eb-880d-4c76-9e44-db939b7e6dd2 */
	.byte	0xeb, 0x74, 0x4a, 0xf5, 0x0d, 0x88, 0x76, 0x4c, 0x9e, 0x44, 0xdb, 0x93, 0x9b, 0x7e, 0x6d, 0xd2
	/* entry_count */
	.long	5
	/* duplicate_count */
	.long	1
	/* map */
	.long	module22_managed_to_java
	/* duplicate_map */
	.long	module22_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Loader */
	.long	.L.map_aname.22
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	/* module_uuid: 719e33ee-f10c-4e8b-add3-6fc44a2e2726 */
	.byte	0xee, 0x33, 0x9e, 0x71, 0x0c, 0xf1, 0x8b, 0x4e, 0xad, 0xd3, 0x6f, 0xc4, 0x4a, 0x2e, 0x27, 0x26
	/* entry_count */
	.long	16
	/* duplicate_count */
	.long	2
	/* map */
	.long	module23_managed_to_java
	/* duplicate_map */
	.long	module23_managed_to_java_duplicates
	/* assembly_name: Xamarin.Google.Android.Material */
	.long	.L.map_aname.23
	/* image */
	.long	0
	/* java_name_width */
	.long	0
	/* java_map */
	.long	0

	.size	map_modules, 1152
/* Managed to Java map: END */

/* Java to managed map: START */
	.section	.rodata.map_java,"a",%progbits
	.type	map_java, %object
	.p2align	2
	.global	map_java
map_java:
	/* #0 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554727
	/* java_name */
	.ascii	"android/animation/Animator"
	.zero	91

	/* #1 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554729
	/* java_name */
	.ascii	"android/animation/Animator$AnimatorListener"
	.zero	74

	/* #2 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554731
	/* java_name */
	.ascii	"android/animation/Animator$AnimatorPauseListener"
	.zero	69

	/* #3 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554734
	/* java_name */
	.ascii	"android/animation/AnimatorListenerAdapter"
	.zero	76

	/* #4 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554738
	/* java_name */
	.ascii	"android/animation/ObjectAnimator"
	.zero	85

	/* #5 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554737
	/* java_name */
	.ascii	"android/animation/TimeInterpolator"
	.zero	83

	/* #6 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554732
	/* java_name */
	.ascii	"android/animation/ValueAnimator"
	.zero	86

	/* #7 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554741
	/* java_name */
	.ascii	"android/app/Activity"
	.zero	97

	/* #8 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554742
	/* java_name */
	.ascii	"android/app/ActivityManager"
	.zero	90

	/* #9 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554743
	/* java_name */
	.ascii	"android/app/ActivityManager$RunningAppProcessInfo"
	.zero	68

	/* #10 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554744
	/* java_name */
	.ascii	"android/app/AlertDialog"
	.zero	94

	/* #11 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554745
	/* java_name */
	.ascii	"android/app/AlertDialog$Builder"
	.zero	86

	/* #12 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554762
	/* java_name */
	.ascii	"android/app/AppOpsManager"
	.zero	92

	/* #13 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554746
	/* java_name */
	.ascii	"android/app/Application"
	.zero	94

	/* #14 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554748
	/* java_name */
	.ascii	"android/app/Application$ActivityLifecycleCallbacks"
	.zero	67

	/* #15 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554749
	/* java_name */
	.ascii	"android/app/Dialog"
	.zero	99

	/* #16 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554754
	/* java_name */
	.ascii	"android/app/Notification"
	.zero	93

	/* #17 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554755
	/* java_name */
	.ascii	"android/app/Notification$Builder"
	.zero	85

	/* #18 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554765
	/* java_name */
	.ascii	"android/app/NotificationChannel"
	.zero	86

	/* #19 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554756
	/* java_name */
	.ascii	"android/app/NotificationManager"
	.zero	86

	/* #20 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554767
	/* java_name */
	.ascii	"android/app/PendingIntent"
	.zero	92

	/* #21 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554770
	/* java_name */
	.ascii	"android/app/Service"
	.zero	98

	/* #22 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554774
	/* java_name */
	.ascii	"android/app/usage/UsageEvents"
	.zero	88

	/* #23 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554775
	/* java_name */
	.ascii	"android/app/usage/UsageEvents$Event"
	.zero	82

	/* #24 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554777
	/* java_name */
	.ascii	"android/app/usage/UsageStatsManager"
	.zero	82

	/* #25 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554786
	/* java_name */
	.ascii	"android/content/BroadcastReceiver"
	.zero	84

	/* #26 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554789
	/* java_name */
	.ascii	"android/content/ClipData"
	.zero	93

	/* #27 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554788
	/* java_name */
	.ascii	"android/content/ClipboardManager"
	.zero	85

	/* #28 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554798
	/* java_name */
	.ascii	"android/content/ComponentCallbacks"
	.zero	83

	/* #29 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554800
	/* java_name */
	.ascii	"android/content/ComponentCallbacks2"
	.zero	82

	/* #30 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554790
	/* java_name */
	.ascii	"android/content/ComponentName"
	.zero	88

	/* #31 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554780
	/* java_name */
	.ascii	"android/content/ContentProvider"
	.zero	86

	/* #32 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554792
	/* java_name */
	.ascii	"android/content/ContentResolver"
	.zero	86

	/* #33 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554781
	/* java_name */
	.ascii	"android/content/ContentValues"
	.zero	88

	/* #34 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554782
	/* java_name */
	.ascii	"android/content/Context"
	.zero	94

	/* #35 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554795
	/* java_name */
	.ascii	"android/content/ContextWrapper"
	.zero	87

	/* #36 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554811
	/* java_name */
	.ascii	"android/content/DialogInterface"
	.zero	86

	/* #37 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554802
	/* java_name */
	.ascii	"android/content/DialogInterface$OnCancelListener"
	.zero	69

	/* #38 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554804
	/* java_name */
	.ascii	"android/content/DialogInterface$OnClickListener"
	.zero	70

	/* #39 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554808
	/* java_name */
	.ascii	"android/content/DialogInterface$OnDismissListener"
	.zero	68

	/* #40 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554783
	/* java_name */
	.ascii	"android/content/Intent"
	.zero	95

	/* #41 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554812
	/* java_name */
	.ascii	"android/content/IntentFilter"
	.zero	89

	/* #42 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554813
	/* java_name */
	.ascii	"android/content/IntentSender"
	.zero	89

	/* #43 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554815
	/* java_name */
	.ascii	"android/content/ServiceConnection"
	.zero	84

	/* #44 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554821
	/* java_name */
	.ascii	"android/content/SharedPreferences"
	.zero	84

	/* #45 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554817
	/* java_name */
	.ascii	"android/content/SharedPreferences$Editor"
	.zero	77

	/* #46 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554819
	/* java_name */
	.ascii	"android/content/SharedPreferences$OnSharedPreferenceChangeListener"
	.zero	51

	/* #47 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554824
	/* java_name */
	.ascii	"android/content/pm/ApplicationInfo"
	.zero	83

	/* #48 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554827
	/* java_name */
	.ascii	"android/content/pm/PackageInfo"
	.zero	87

	/* #49 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554829
	/* java_name */
	.ascii	"android/content/pm/PackageItemInfo"
	.zero	83

	/* #50 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554830
	/* java_name */
	.ascii	"android/content/pm/PackageManager"
	.zero	84

	/* #51 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554833
	/* java_name */
	.ascii	"android/content/pm/ResolveInfo"
	.zero	87

	/* #52 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554834
	/* java_name */
	.ascii	"android/content/res/ColorStateList"
	.zero	83

	/* #53 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554835
	/* java_name */
	.ascii	"android/content/res/Configuration"
	.zero	84

	/* #54 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554836
	/* java_name */
	.ascii	"android/content/res/Resources"
	.zero	88

	/* #55 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554837
	/* java_name */
	.ascii	"android/content/res/Resources$Theme"
	.zero	82

	/* #56 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554487
	/* java_name */
	.ascii	"android/database/CharArrayBuffer"
	.zero	85

	/* #57 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554488
	/* java_name */
	.ascii	"android/database/ContentObserver"
	.zero	85

	/* #58 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554494
	/* java_name */
	.ascii	"android/database/Cursor"
	.zero	94

	/* #59 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554490
	/* java_name */
	.ascii	"android/database/DataSetObserver"
	.zero	85

	/* #60 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554705
	/* java_name */
	.ascii	"android/graphics/Bitmap"
	.zero	94

	/* #61 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554709
	/* java_name */
	.ascii	"android/graphics/BitmapFactory"
	.zero	87

	/* #62 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554706
	/* java_name */
	.ascii	"android/graphics/Canvas"
	.zero	94

	/* #63 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554711
	/* java_name */
	.ascii	"android/graphics/Color"
	.zero	95

	/* #64 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554710
	/* java_name */
	.ascii	"android/graphics/ColorFilter"
	.zero	89

	/* #65 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554713
	/* java_name */
	.ascii	"android/graphics/Matrix"
	.zero	94

	/* #66 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554714
	/* java_name */
	.ascii	"android/graphics/Paint"
	.zero	95

	/* #67 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554715
	/* java_name */
	.ascii	"android/graphics/Point"
	.zero	95

	/* #68 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554716
	/* java_name */
	.ascii	"android/graphics/PorterDuff"
	.zero	90

	/* #69 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554717
	/* java_name */
	.ascii	"android/graphics/PorterDuff$Mode"
	.zero	85

	/* #70 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554718
	/* java_name */
	.ascii	"android/graphics/Rect"
	.zero	96

	/* #71 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554719
	/* java_name */
	.ascii	"android/graphics/RectF"
	.zero	95

	/* #72 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554720
	/* java_name */
	.ascii	"android/graphics/Typeface"
	.zero	92

	/* #73 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554722
	/* java_name */
	.ascii	"android/graphics/drawable/Drawable"
	.zero	83

	/* #74 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554724
	/* java_name */
	.ascii	"android/graphics/drawable/Drawable$Callback"
	.zero	74

	/* #75 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554726
	/* java_name */
	.ascii	"android/graphics/drawable/Icon"
	.zero	87

	/* #76 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554702
	/* java_name */
	.ascii	"android/net/Uri"
	.zero	102

	/* #77 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554680
	/* java_name */
	.ascii	"android/os/BaseBundle"
	.zero	96

	/* #78 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554681
	/* java_name */
	.ascii	"android/os/Binder"
	.zero	100

	/* #79 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554682
	/* java_name */
	.ascii	"android/os/Build"
	.zero	101

	/* #80 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554683
	/* java_name */
	.ascii	"android/os/Build$VERSION"
	.zero	93

	/* #81 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554685
	/* java_name */
	.ascii	"android/os/Bundle"
	.zero	100

	/* #82 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554686
	/* java_name */
	.ascii	"android/os/Environment"
	.zero	95

	/* #83 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554679
	/* java_name */
	.ascii	"android/os/Handler"
	.zero	99

	/* #84 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554690
	/* java_name */
	.ascii	"android/os/IBinder"
	.zero	99

	/* #85 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554688
	/* java_name */
	.ascii	"android/os/IBinder$DeathRecipient"
	.zero	84

	/* #86 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554692
	/* java_name */
	.ascii	"android/os/IInterface"
	.zero	96

	/* #87 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554697
	/* java_name */
	.ascii	"android/os/Looper"
	.zero	100

	/* #88 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554698
	/* java_name */
	.ascii	"android/os/Parcel"
	.zero	100

	/* #89 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554696
	/* java_name */
	.ascii	"android/os/Parcelable"
	.zero	96

	/* #90 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554694
	/* java_name */
	.ascii	"android/os/Parcelable$Creator"
	.zero	88

	/* #91 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554700
	/* java_name */
	.ascii	"android/os/Process"
	.zero	99

	/* #92 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554678
	/* java_name */
	.ascii	"android/preference/PreferenceManager"
	.zero	81

	/* #93 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554883
	/* java_name */
	.ascii	"android/runtime/JavaProxyThrowable"
	.zero	83

	/* #94 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554643
	/* java_name */
	.ascii	"android/text/ClipboardManager"
	.zero	88

	/* #95 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554651
	/* java_name */
	.ascii	"android/text/Editable"
	.zero	96

	/* #96 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554654
	/* java_name */
	.ascii	"android/text/GetChars"
	.zero	96

	/* #97 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554649
	/* java_name */
	.ascii	"android/text/Html"
	.zero	100

	/* #98 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554657
	/* java_name */
	.ascii	"android/text/InputFilter"
	.zero	93

	/* #99 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554659
	/* java_name */
	.ascii	"android/text/NoCopySpan"
	.zero	94

	/* #100 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554662
	/* java_name */
	.ascii	"android/text/Spannable"
	.zero	95

	/* #101 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554665
	/* java_name */
	.ascii	"android/text/Spanned"
	.zero	97

	/* #102 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554668
	/* java_name */
	.ascii	"android/text/TextDirectionHeuristic"
	.zero	82

	/* #103 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554672
	/* java_name */
	.ascii	"android/text/TextPaint"
	.zero	95

	/* #104 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554670
	/* java_name */
	.ascii	"android/text/TextWatcher"
	.zero	93

	/* #105 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554673
	/* java_name */
	.ascii	"android/text/method/BaseMovementMethod"
	.zero	79

	/* #106 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554676
	/* java_name */
	.ascii	"android/text/method/LinkMovementMethod"
	.zero	79

	/* #107 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554675
	/* java_name */
	.ascii	"android/text/method/MovementMethod"
	.zero	83

	/* #108 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554677
	/* java_name */
	.ascii	"android/text/method/ScrollingMovementMethod"
	.zero	74

	/* #109 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554640
	/* java_name */
	.ascii	"android/util/AttributeSet"
	.zero	92

	/* #110 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554636
	/* java_name */
	.ascii	"android/util/Base64"
	.zero	98

	/* #111 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554638
	/* java_name */
	.ascii	"android/util/DisplayMetrics"
	.zero	90

	/* #112 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554635
	/* java_name */
	.ascii	"android/util/Log"
	.zero	101

	/* #113 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554641
	/* java_name */
	.ascii	"android/util/SparseArray"
	.zero	93

	/* #114 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554642
	/* java_name */
	.ascii	"android/util/TypedValue"
	.zero	94

	/* #115 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554560
	/* java_name */
	.ascii	"android/view/ActionMode"
	.zero	94

	/* #116 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554562
	/* java_name */
	.ascii	"android/view/ActionMode$Callback"
	.zero	85

	/* #117 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554565
	/* java_name */
	.ascii	"android/view/ActionProvider"
	.zero	90

	/* #118 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554575
	/* java_name */
	.ascii	"android/view/ContextMenu"
	.zero	93

	/* #119 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554573
	/* java_name */
	.ascii	"android/view/ContextMenu$ContextMenuInfo"
	.zero	77

	/* #120 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554567
	/* java_name */
	.ascii	"android/view/ContextThemeWrapper"
	.zero	85

	/* #121 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554568
	/* java_name */
	.ascii	"android/view/Display"
	.zero	97

	/* #122 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554569
	/* java_name */
	.ascii	"android/view/DragEvent"
	.zero	95

	/* #123 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554584
	/* java_name */
	.ascii	"android/view/InputEvent"
	.zero	94

	/* #124 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554543
	/* java_name */
	.ascii	"android/view/KeyEvent"
	.zero	96

	/* #125 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554545
	/* java_name */
	.ascii	"android/view/KeyEvent$Callback"
	.zero	87

	/* #126 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554546
	/* java_name */
	.ascii	"android/view/LayoutInflater"
	.zero	90

	/* #127 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554548
	/* java_name */
	.ascii	"android/view/LayoutInflater$Factory"
	.zero	82

	/* #128 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554550
	/* java_name */
	.ascii	"android/view/LayoutInflater$Factory2"
	.zero	81

	/* #129 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554552
	/* java_name */
	.ascii	"android/view/LayoutInflater$Filter"
	.zero	83

	/* #130 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554577
	/* java_name */
	.ascii	"android/view/Menu"
	.zero	100

	/* #131 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554599
	/* java_name */
	.ascii	"android/view/MenuInflater"
	.zero	92

	/* #132 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554583
	/* java_name */
	.ascii	"android/view/MenuItem"
	.zero	96

	/* #133 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554579
	/* java_name */
	.ascii	"android/view/MenuItem$OnActionExpandListener"
	.zero	73

	/* #134 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554581
	/* java_name */
	.ascii	"android/view/MenuItem$OnMenuItemClickListener"
	.zero	72

	/* #135 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554553
	/* java_name */
	.ascii	"android/view/MotionEvent"
	.zero	93

	/* #136 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554602
	/* java_name */
	.ascii	"android/view/SearchEvent"
	.zero	93

	/* #137 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554587
	/* java_name */
	.ascii	"android/view/SubMenu"
	.zero	97

	/* #138 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554529
	/* java_name */
	.ascii	"android/view/View"
	.zero	100

	/* #139 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554531
	/* java_name */
	.ascii	"android/view/View$OnClickListener"
	.zero	84

	/* #140 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554534
	/* java_name */
	.ascii	"android/view/View$OnCreateContextMenuListener"
	.zero	72

	/* #141 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554536
	/* java_name */
	.ascii	"android/view/View$OnTouchListener"
	.zero	84

	/* #142 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554607
	/* java_name */
	.ascii	"android/view/ViewGroup"
	.zero	95

	/* #143 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554608
	/* java_name */
	.ascii	"android/view/ViewGroup$LayoutParams"
	.zero	82

	/* #144 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554609
	/* java_name */
	.ascii	"android/view/ViewGroup$MarginLayoutParams"
	.zero	76

	/* #145 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554589
	/* java_name */
	.ascii	"android/view/ViewManager"
	.zero	93

	/* #146 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554591
	/* java_name */
	.ascii	"android/view/ViewParent"
	.zero	94

	/* #147 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554611
	/* java_name */
	.ascii	"android/view/ViewPropertyAnimator"
	.zero	84

	/* #148 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554554
	/* java_name */
	.ascii	"android/view/ViewTreeObserver"
	.zero	88

	/* #149 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554556
	/* java_name */
	.ascii	"android/view/ViewTreeObserver$OnPreDrawListener"
	.zero	70

	/* #150 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554557
	/* java_name */
	.ascii	"android/view/Window"
	.zero	98

	/* #151 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554559
	/* java_name */
	.ascii	"android/view/Window$Callback"
	.zero	89

	/* #152 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554614
	/* java_name */
	.ascii	"android/view/WindowInsets"
	.zero	92

	/* #153 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554594
	/* java_name */
	.ascii	"android/view/WindowManager"
	.zero	91

	/* #154 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554592
	/* java_name */
	.ascii	"android/view/WindowManager$LayoutParams"
	.zero	78

	/* #155 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554628
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityEvent"
	.zero	72

	/* #156 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554634
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityEventSource"
	.zero	66

	/* #157 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554629
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityRecord"
	.zero	71

	/* #158 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554617
	/* java_name */
	.ascii	"android/view/animation/Animation"
	.zero	85

	/* #159 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554619
	/* java_name */
	.ascii	"android/view/animation/BaseInterpolator"
	.zero	78

	/* #160 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554622
	/* java_name */
	.ascii	"android/view/animation/Interpolator"
	.zero	82

	/* #161 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554623
	/* java_name */
	.ascii	"android/view/animation/LinearInterpolator"
	.zero	76

	/* #162 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554624
	/* java_name */
	.ascii	"android/view/inputmethod/InputMethodManager"
	.zero	74

	/* #163 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554513
	/* java_name */
	.ascii	"android/widget/Adapter"
	.zero	95

	/* #164 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554495
	/* java_name */
	.ascii	"android/widget/AdapterView"
	.zero	91

	/* #165 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554497
	/* java_name */
	.ascii	"android/widget/AdapterView$OnItemSelectedListener"
	.zero	68

	/* #166 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554508
	/* java_name */
	.ascii	"android/widget/Button"
	.zero	96

	/* #167 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554509
	/* java_name */
	.ascii	"android/widget/EditText"
	.zero	94

	/* #168 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554510
	/* java_name */
	.ascii	"android/widget/FrameLayout"
	.zero	91

	/* #169 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554511
	/* java_name */
	.ascii	"android/widget/HorizontalScrollView"
	.zero	82

	/* #170 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554514
	/* java_name */
	.ascii	"android/widget/ImageView"
	.zero	93

	/* #171 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554517
	/* java_name */
	.ascii	"android/widget/LinearLayout"
	.zero	90

	/* #172 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554518
	/* java_name */
	.ascii	"android/widget/LinearLayout$LayoutParams"
	.zero	77

	/* #173 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554520
	/* java_name */
	.ascii	"android/widget/ProgressBar"
	.zero	91

	/* #174 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554521
	/* java_name */
	.ascii	"android/widget/RelativeLayout"
	.zero	88

	/* #175 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554522
	/* java_name */
	.ascii	"android/widget/RelativeLayout$LayoutParams"
	.zero	75

	/* #176 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554523
	/* java_name */
	.ascii	"android/widget/RemoteViews"
	.zero	91

	/* #177 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554516
	/* java_name */
	.ascii	"android/widget/SpinnerAdapter"
	.zero	88

	/* #178 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554524
	/* java_name */
	.ascii	"android/widget/TableLayout"
	.zero	91

	/* #179 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554525
	/* java_name */
	.ascii	"android/widget/TableRow"
	.zero	94

	/* #180 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554498
	/* java_name */
	.ascii	"android/widget/TextView"
	.zero	94

	/* #181 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554499
	/* java_name */
	.ascii	"android/widget/TextView$BufferType"
	.zero	83

	/* #182 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554501
	/* java_name */
	.ascii	"android/widget/TextView$OnEditorActionListener"
	.zero	71

	/* #183 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554526
	/* java_name */
	.ascii	"android/widget/Toast"
	.zero	97

	/* #184 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554528
	/* java_name */
	.ascii	"android/widget/Toolbar"
	.zero	95

	/* #185 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/activity/ComponentActivity"
	.zero	82

	/* #186 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"androidx/activity/OnBackPressedCallback"
	.zero	78

	/* #187 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"androidx/activity/OnBackPressedDispatcher"
	.zero	76

	/* #188 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/activity/OnBackPressedDispatcherOwner"
	.zero	71

	/* #189 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar"
	.zero	85

	/* #190 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$LayoutParams"
	.zero	72

	/* #191 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$OnMenuVisibilityListener"
	.zero	60

	/* #192 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554443
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$OnNavigationListener"
	.zero	64

	/* #193 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554444
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$Tab"
	.zero	81

	/* #194 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554447
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$TabListener"
	.zero	73

	/* #195 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554451
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBarDrawerToggle"
	.zero	73

	/* #196 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554453
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBarDrawerToggle$Delegate"
	.zero	64

	/* #197 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554455
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBarDrawerToggle$DelegateProvider"
	.zero	56

	/* #198 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554456
	/* java_name */
	.ascii	"androidx/appcompat/app/AppCompatActivity"
	.zero	77

	/* #199 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554460
	/* java_name */
	.ascii	"androidx/appcompat/app/AppCompatCallback"
	.zero	77

	/* #200 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554457
	/* java_name */
	.ascii	"androidx/appcompat/app/AppCompatDelegate"
	.zero	77

	/* #201 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/appcompat/graphics/drawable/DrawerArrowDrawable"
	.zero	61

	/* #202 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554476
	/* java_name */
	.ascii	"androidx/appcompat/view/ActionMode"
	.zero	83

	/* #203 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554478
	/* java_name */
	.ascii	"androidx/appcompat/view/ActionMode$Callback"
	.zero	74

	/* #204 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554480
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuBuilder"
	.zero	77

	/* #205 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554482
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuBuilder$Callback"
	.zero	68

	/* #206 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554489
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuItemImpl"
	.zero	76

	/* #207 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554486
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuPresenter"
	.zero	75

	/* #208 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554484
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuPresenter$Callback"
	.zero	66

	/* #209 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554488
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuView"
	.zero	80

	/* #210 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554490
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/SubMenuBuilder"
	.zero	74

	/* #211 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554470
	/* java_name */
	.ascii	"androidx/appcompat/widget/AppCompatEditText"
	.zero	74

	/* #212 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554471
	/* java_name */
	.ascii	"androidx/appcompat/widget/AppCompatTextView"
	.zero	74

	/* #213 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554473
	/* java_name */
	.ascii	"androidx/appcompat/widget/DecorToolbar"
	.zero	79

	/* #214 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554474
	/* java_name */
	.ascii	"androidx/appcompat/widget/ScrollingTabContainerView"
	.zero	66

	/* #215 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554475
	/* java_name */
	.ascii	"androidx/appcompat/widget/ScrollingTabContainerView$VisibilityAnimListener"
	.zero	43

	/* #216 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554461
	/* java_name */
	.ascii	"androidx/appcompat/widget/Toolbar"
	.zero	84

	/* #217 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554465
	/* java_name */
	.ascii	"androidx/appcompat/widget/Toolbar$OnMenuItemClickListener"
	.zero	60

	/* #218 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554462
	/* java_name */
	.ascii	"androidx/appcompat/widget/Toolbar_NavigationOnClickEventDispatcher"
	.zero	51

	/* #219 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/cardview/widget/CardView"
	.zero	84

	/* #220 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/coordinatorlayout/widget/CoordinatorLayout"
	.zero	66

	/* #221 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/coordinatorlayout/widget/CoordinatorLayout$Behavior"
	.zero	57

	/* #222 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"androidx/coordinatorlayout/widget/CoordinatorLayout$LayoutParams"
	.zero	53

	/* #223 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554481
	/* java_name */
	.ascii	"androidx/core/app/ActivityCompat"
	.zero	85

	/* #224 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554483
	/* java_name */
	.ascii	"androidx/core/app/ActivityCompat$OnRequestPermissionsResultCallback"
	.zero	50

	/* #225 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554485
	/* java_name */
	.ascii	"androidx/core/app/ActivityCompat$PermissionCompatDelegate"
	.zero	60

	/* #226 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554487
	/* java_name */
	.ascii	"androidx/core/app/ActivityCompat$RequestPermissionsRequestCodeValidator"
	.zero	46

	/* #227 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554488
	/* java_name */
	.ascii	"androidx/core/app/ComponentActivity"
	.zero	82

	/* #228 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554489
	/* java_name */
	.ascii	"androidx/core/app/ComponentActivity$ExtraData"
	.zero	72

	/* #229 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554491
	/* java_name */
	.ascii	"androidx/core/app/NotificationBuilderWithBuilderAccessor"
	.zero	61

	/* #230 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554492
	/* java_name */
	.ascii	"androidx/core/app/NotificationCompat"
	.zero	81

	/* #231 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554493
	/* java_name */
	.ascii	"androidx/core/app/NotificationCompat$Action"
	.zero	74

	/* #232 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554494
	/* java_name */
	.ascii	"androidx/core/app/NotificationCompat$BubbleMetadata"
	.zero	66

	/* #233 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554495
	/* java_name */
	.ascii	"androidx/core/app/NotificationCompat$Builder"
	.zero	73

	/* #234 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554497
	/* java_name */
	.ascii	"androidx/core/app/NotificationCompat$Extender"
	.zero	72

	/* #235 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554498
	/* java_name */
	.ascii	"androidx/core/app/NotificationCompat$Style"
	.zero	75

	/* #236 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554500
	/* java_name */
	.ascii	"androidx/core/app/RemoteInput"
	.zero	88

	/* #237 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554501
	/* java_name */
	.ascii	"androidx/core/app/SharedElementCallback"
	.zero	78

	/* #238 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554503
	/* java_name */
	.ascii	"androidx/core/app/SharedElementCallback$OnSharedElementsReadyListener"
	.zero	48

	/* #239 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554505
	/* java_name */
	.ascii	"androidx/core/app/TaskStackBuilder"
	.zero	83

	/* #240 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554507
	/* java_name */
	.ascii	"androidx/core/app/TaskStackBuilder$SupportParentable"
	.zero	65

	/* #241 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554479
	/* java_name */
	.ascii	"androidx/core/content/ContextCompat"
	.zero	82

	/* #242 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554480
	/* java_name */
	.ascii	"androidx/core/content/FileProvider"
	.zero	83

	/* #243 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554477
	/* java_name */
	.ascii	"androidx/core/graphics/Insets"
	.zero	88

	/* #244 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554478
	/* java_name */
	.ascii	"androidx/core/graphics/drawable/IconCompat"
	.zero	75

	/* #245 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554474
	/* java_name */
	.ascii	"androidx/core/internal/view/SupportMenu"
	.zero	78

	/* #246 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554476
	/* java_name */
	.ascii	"androidx/core/internal/view/SupportMenuItem"
	.zero	74

	/* #247 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554508
	/* java_name */
	.ascii	"androidx/core/text/PrecomputedTextCompat"
	.zero	77

	/* #248 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554509
	/* java_name */
	.ascii	"androidx/core/text/PrecomputedTextCompat$Params"
	.zero	70

	/* #249 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"androidx/core/view/ActionProvider"
	.zero	84

	/* #250 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"androidx/core/view/ActionProvider$SubUiVisibilityListener"
	.zero	60

	/* #251 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554446
	/* java_name */
	.ascii	"androidx/core/view/ActionProvider$VisibilityListener"
	.zero	65

	/* #252 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554454
	/* java_name */
	.ascii	"androidx/core/view/DisplayCutoutCompat"
	.zero	79

	/* #253 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554455
	/* java_name */
	.ascii	"androidx/core/view/DragAndDropPermissionsCompat"
	.zero	70

	/* #254 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554468
	/* java_name */
	.ascii	"androidx/core/view/KeyEventDispatcher"
	.zero	80

	/* #255 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554470
	/* java_name */
	.ascii	"androidx/core/view/KeyEventDispatcher$Component"
	.zero	70

	/* #256 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554457
	/* java_name */
	.ascii	"androidx/core/view/NestedScrollingParent"
	.zero	77

	/* #257 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554459
	/* java_name */
	.ascii	"androidx/core/view/NestedScrollingParent2"
	.zero	76

	/* #258 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554461
	/* java_name */
	.ascii	"androidx/core/view/NestedScrollingParent3"
	.zero	76

	/* #259 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554463
	/* java_name */
	.ascii	"androidx/core/view/TintableBackgroundView"
	.zero	76

	/* #260 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554471
	/* java_name */
	.ascii	"androidx/core/view/ViewPropertyAnimatorCompat"
	.zero	72

	/* #261 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554465
	/* java_name */
	.ascii	"androidx/core/view/ViewPropertyAnimatorListener"
	.zero	70

	/* #262 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554467
	/* java_name */
	.ascii	"androidx/core/view/ViewPropertyAnimatorUpdateListener"
	.zero	64

	/* #263 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554472
	/* java_name */
	.ascii	"androidx/core/view/WindowInsetsCompat"
	.zero	80

	/* #264 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/core/widget/AutoSizeableTextView"
	.zero	76

	/* #265 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"androidx/core/widget/TextViewCompat"
	.zero	82

	/* #266 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"androidx/core/widget/TintableCompoundDrawablesView"
	.zero	67

	/* #267 */
	/* module_index */
	.long	10
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/drawerlayout/widget/DrawerLayout"
	.zero	76

	/* #268 */
	/* module_index */
	.long	10
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/drawerlayout/widget/DrawerLayout$DrawerListener"
	.zero	61

	/* #269 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/fragment/app/DialogFragment"
	.zero	81

	/* #270 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/fragment/app/Fragment"
	.zero	87

	/* #271 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"androidx/fragment/app/Fragment$SavedState"
	.zero	76

	/* #272 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentActivity"
	.zero	79

	/* #273 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentFactory"
	.zero	80

	/* #274 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentManager"
	.zero	80

	/* #275 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentManager$BackStackEntry"
	.zero	65

	/* #276 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554443
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentManager$FragmentLifecycleCallbacks"
	.zero	53

	/* #277 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554446
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentManager$OnBackStackChangedListener"
	.zero	53

	/* #278 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554451
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentTransaction"
	.zero	76

	/* #279 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/lifecycle/Lifecycle"
	.zero	89

	/* #280 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/lifecycle/Lifecycle$State"
	.zero	83

	/* #281 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"androidx/lifecycle/LifecycleObserver"
	.zero	81

	/* #282 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"androidx/lifecycle/LifecycleOwner"
	.zero	84

	/* #283 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/lifecycle/LiveData"
	.zero	90

	/* #284 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/lifecycle/Observer"
	.zero	90

	/* #285 */
	/* module_index */
	.long	18
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/lifecycle/ViewModelStore"
	.zero	84

	/* #286 */
	/* module_index */
	.long	18
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/lifecycle/ViewModelStoreOwner"
	.zero	79

	/* #287 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"androidx/loader/app/LoaderManager"
	.zero	84

	/* #288 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"androidx/loader/app/LoaderManager$LoaderCallbacks"
	.zero	68

	/* #289 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/loader/content/Loader"
	.zero	87

	/* #290 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/loader/content/Loader$OnLoadCanceledListener"
	.zero	64

	/* #291 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"androidx/loader/content/Loader$OnLoadCompleteListener"
	.zero	64

	/* #292 */
	/* module_index */
	.long	14
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/savedstate/SavedStateRegistry"
	.zero	79

	/* #293 */
	/* module_index */
	.long	14
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"androidx/savedstate/SavedStateRegistry$SavedStateProvider"
	.zero	60

	/* #294 */
	/* module_index */
	.long	14
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/savedstate/SavedStateRegistryOwner"
	.zero	74

	/* #295 */
	/* module_index */
	.long	11
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/versionedparcelable/CustomVersionedParcelable"
	.zero	63

	/* #296 */
	/* module_index */
	.long	11
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"androidx/versionedparcelable/VersionedParcelable"
	.zero	69

	/* #297 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"com/google/android/gms/tasks/CancellationToken"
	.zero	71

	/* #298 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"com/google/android/gms/tasks/Continuation"
	.zero	76

	/* #299 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"com/google/android/gms/tasks/OnCanceledListener"
	.zero	70

	/* #300 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554444
	/* java_name */
	.ascii	"com/google/android/gms/tasks/OnCompleteListener"
	.zero	70

	/* #301 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554446
	/* java_name */
	.ascii	"com/google/android/gms/tasks/OnFailureListener"
	.zero	71

	/* #302 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554448
	/* java_name */
	.ascii	"com/google/android/gms/tasks/OnSuccessListener"
	.zero	71

	/* #303 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554450
	/* java_name */
	.ascii	"com/google/android/gms/tasks/OnTokenCanceledListener"
	.zero	65

	/* #304 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554452
	/* java_name */
	.ascii	"com/google/android/gms/tasks/SuccessContinuation"
	.zero	69

	/* #305 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"com/google/android/gms/tasks/Task"
	.zero	84

	/* #306 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"com/google/android/gms/tasks/TaskCompletionSource"
	.zero	68

	/* #307 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"com/google/android/material/behavior/SwipeDismissBehavior"
	.zero	60

	/* #308 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"com/google/android/material/behavior/SwipeDismissBehavior$OnDismissListener"
	.zero	42

	/* #309 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554452
	/* java_name */
	.ascii	"com/google/android/material/bottomnavigation/BottomNavigationView"
	.zero	52

	/* #310 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554454
	/* java_name */
	.ascii	"com/google/android/material/bottomnavigation/BottomNavigationView$OnNavigationItemReselectedListener"
	.zero	17

	/* #311 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554458
	/* java_name */
	.ascii	"com/google/android/material/bottomnavigation/BottomNavigationView$OnNavigationItemSelectedListener"
	.zero	19

	/* #312 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554445
	/* java_name */
	.ascii	"com/google/android/material/snackbar/BaseTransientBottomBar"
	.zero	58

	/* #313 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554446
	/* java_name */
	.ascii	"com/google/android/material/snackbar/BaseTransientBottomBar$BaseCallback"
	.zero	45

	/* #314 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554448
	/* java_name */
	.ascii	"com/google/android/material/snackbar/BaseTransientBottomBar$Behavior"
	.zero	49

	/* #315 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554451
	/* java_name */
	.ascii	"com/google/android/material/snackbar/ContentViewCallback"
	.zero	61

	/* #316 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"com/google/android/material/snackbar/Snackbar"
	.zero	72

	/* #317 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554444
	/* java_name */
	.ascii	"com/google/android/material/snackbar/Snackbar$Callback"
	.zero	63

	/* #318 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554443
	/* java_name */
	.ascii	"com/google/android/material/snackbar/Snackbar_SnackbarActionClickImplementor"
	.zero	41

	/* #319 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554441
	/* java_name */
	.ascii	"com/google/android/material/textfield/TextInputEditText"
	.zero	62

	/* #320 */
	/* module_index */
	.long	19
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"com/google/auto/value/AutoAnnotation"
	.zero	81

	/* #321 */
	/* module_index */
	.long	19
	/* type_token_id */
	.long	33554441
	/* java_name */
	.ascii	"com/google/auto/value/AutoOneOf"
	.zero	86

	/* #322 */
	/* module_index */
	.long	19
	/* type_token_id */
	.long	33554447
	/* java_name */
	.ascii	"com/google/auto/value/AutoValue"
	.zero	86

	/* #323 */
	/* module_index */
	.long	19
	/* type_token_id */
	.long	33554443
	/* java_name */
	.ascii	"com/google/auto/value/AutoValue$Builder"
	.zero	78

	/* #324 */
	/* module_index */
	.long	19
	/* type_token_id */
	.long	33554445
	/* java_name */
	.ascii	"com/google/auto/value/AutoValue$CopyAnnotations"
	.zero	70

	/* #325 */
	/* module_index */
	.long	19
	/* type_token_id */
	.long	33554449
	/* java_name */
	.ascii	"com/google/auto/value/extension/memoized/Memoized"
	.zero	68

	/* #326 */
	/* module_index */
	.long	21
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"com/google/common/util/concurrent/ListenableFuture"
	.zero	67

	/* #327 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"com/google/firebase/analytics/FirebaseAnalytics"
	.zero	70

	/* #328 */
	/* module_index */
	.long	13
	/* type_token_id */
	.long	33554568
	/* java_name */
	.ascii	"crc64011f11f03f56d783/MainActivity"
	.zero	83

	/* #329 */
	/* module_index */
	.long	13
	/* type_token_id */
	.long	33554542
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/BlackoutFragment"
	.zero	79

	/* #330 */
	/* module_index */
	.long	13
	/* type_token_id */
	.long	33554537
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/BlackoutSetupFragment"
	.zero	74

	/* #331 */
	/* module_index */
	.long	13
	/* type_token_id */
	.long	33554559
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/CalendarFragment"
	.zero	79

	/* #332 */
	/* module_index */
	.long	13
	/* type_token_id */
	.long	33554538
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/FeedbackFragment"
	.zero	79

	/* #333 */
	/* module_index */
	.long	13
	/* type_token_id */
	.long	33554567
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/FirstTimeSetupFragment"
	.zero	73

	/* #334 */
	/* module_index */
	.long	13
	/* type_token_id */
	.long	33554560
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/HomeFragment"
	.zero	83

	/* #335 */
	/* module_index */
	.long	13
	/* type_token_id */
	.long	33554533
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/OpenSourceDialogFragment"
	.zero	71

	/* #336 */
	/* module_index */
	.long	13
	/* type_token_id */
	.long	33554550
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/SettingsFragment"
	.zero	79

	/* #337 */
	/* module_index */
	.long	13
	/* type_token_id */
	.long	33554549
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/StoreFragment"
	.zero	82

	/* #338 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"crc64435a5ac349fa9fda/ActivityLifecycleContextListener"
	.zero	63

	/* #339 */
	/* module_index */
	.long	13
	/* type_token_id */
	.long	33554459
	/* java_name */
	.ascii	"crc648f9c7c37abc5d059/BootMessageReceiver"
	.zero	76

	/* #340 */
	/* module_index */
	.long	13
	/* type_token_id */
	.long	33554460
	/* java_name */
	.ascii	"crc648f9c7c37abc5d059/GenericBroadcastReceiver"
	.zero	71

	/* #341 */
	/* module_index */
	.long	13
	/* type_token_id */
	.long	33554453
	/* java_name */
	.ascii	"crc64940f4e21f98af2d5/EnforcerService"
	.zero	80

	/* #342 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"crc6495d4f5d63cc5c882/AwaitableTaskCompleteListener_1"
	.zero	64

	/* #343 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554459
	/* java_name */
	.ascii	"crc64a0e0a82d0db9a07d/ActivityLifecycleContextListener"
	.zero	63

	/* #344 */
	/* module_index */
	.long	16
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"crc64b5a97285ca981d80/InAppBillingImplementation_InAppBillingServiceConnection"
	.zero	39

	/* #345 */
	/* module_index */
	.long	20
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"crc64bffe522d9943944b/IInAppBillingServiceStub"
	.zero	71

	/* #346 */
	/* module_index */
	.long	20
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"crc64bffe522d9943944b/IInAppBillingServiceStub_Proxy"
	.zero	65

	/* #347 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555050
	/* java_name */
	.ascii	"java/io/Closeable"
	.zero	100

	/* #348 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555046
	/* java_name */
	.ascii	"java/io/File"
	.zero	105

	/* #349 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555047
	/* java_name */
	.ascii	"java/io/FileDescriptor"
	.zero	95

	/* #350 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555048
	/* java_name */
	.ascii	"java/io/FileInputStream"
	.zero	94

	/* #351 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555052
	/* java_name */
	.ascii	"java/io/Flushable"
	.zero	100

	/* #352 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555055
	/* java_name */
	.ascii	"java/io/IOException"
	.zero	98

	/* #353 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555053
	/* java_name */
	.ascii	"java/io/InputStream"
	.zero	98

	/* #354 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555058
	/* java_name */
	.ascii	"java/io/OutputStream"
	.zero	97

	/* #355 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555060
	/* java_name */
	.ascii	"java/io/PrintWriter"
	.zero	98

	/* #356 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555057
	/* java_name */
	.ascii	"java/io/Serializable"
	.zero	97

	/* #357 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555061
	/* java_name */
	.ascii	"java/io/StringWriter"
	.zero	97

	/* #358 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555062
	/* java_name */
	.ascii	"java/io/Writer"
	.zero	103

	/* #359 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555015
	/* java_name */
	.ascii	"java/lang/Appendable"
	.zero	97

	/* #360 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554989
	/* java_name */
	.ascii	"java/lang/Boolean"
	.zero	100

	/* #361 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554990
	/* java_name */
	.ascii	"java/lang/Byte"
	.zero	103

	/* #362 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555016
	/* java_name */
	.ascii	"java/lang/CharSequence"
	.zero	95

	/* #363 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554991
	/* java_name */
	.ascii	"java/lang/Character"
	.zero	98

	/* #364 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554992
	/* java_name */
	.ascii	"java/lang/Class"
	.zero	102

	/* #365 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555008
	/* java_name */
	.ascii	"java/lang/ClassCastException"
	.zero	89

	/* #366 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555009
	/* java_name */
	.ascii	"java/lang/ClassLoader"
	.zero	96

	/* #367 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554993
	/* java_name */
	.ascii	"java/lang/ClassNotFoundException"
	.zero	85

	/* #368 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555019
	/* java_name */
	.ascii	"java/lang/Cloneable"
	.zero	98

	/* #369 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555021
	/* java_name */
	.ascii	"java/lang/Comparable"
	.zero	97

	/* #370 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554994
	/* java_name */
	.ascii	"java/lang/Double"
	.zero	101

	/* #371 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555011
	/* java_name */
	.ascii	"java/lang/Enum"
	.zero	103

	/* #372 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555013
	/* java_name */
	.ascii	"java/lang/Error"
	.zero	102

	/* #373 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554995
	/* java_name */
	.ascii	"java/lang/Exception"
	.zero	98

	/* #374 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554996
	/* java_name */
	.ascii	"java/lang/Float"
	.zero	102

	/* #375 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555024
	/* java_name */
	.ascii	"java/lang/IllegalArgumentException"
	.zero	83

	/* #376 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555025
	/* java_name */
	.ascii	"java/lang/IllegalStateException"
	.zero	86

	/* #377 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555026
	/* java_name */
	.ascii	"java/lang/IndexOutOfBoundsException"
	.zero	82

	/* #378 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554998
	/* java_name */
	.ascii	"java/lang/Integer"
	.zero	100

	/* #379 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555023
	/* java_name */
	.ascii	"java/lang/Iterable"
	.zero	99

	/* #380 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555029
	/* java_name */
	.ascii	"java/lang/LinkageError"
	.zero	95

	/* #381 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554999
	/* java_name */
	.ascii	"java/lang/Long"
	.zero	103

	/* #382 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555030
	/* java_name */
	.ascii	"java/lang/NoClassDefFoundError"
	.zero	87

	/* #383 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555031
	/* java_name */
	.ascii	"java/lang/NullPointerException"
	.zero	87

	/* #384 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555032
	/* java_name */
	.ascii	"java/lang/Number"
	.zero	101

	/* #385 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555000
	/* java_name */
	.ascii	"java/lang/Object"
	.zero	101

	/* #386 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555034
	/* java_name */
	.ascii	"java/lang/ReflectiveOperationException"
	.zero	79

	/* #387 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555028
	/* java_name */
	.ascii	"java/lang/Runnable"
	.zero	99

	/* #388 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555001
	/* java_name */
	.ascii	"java/lang/RuntimeException"
	.zero	91

	/* #389 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555002
	/* java_name */
	.ascii	"java/lang/Short"
	.zero	102

	/* #390 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555003
	/* java_name */
	.ascii	"java/lang/String"
	.zero	101

	/* #391 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555005
	/* java_name */
	.ascii	"java/lang/Thread"
	.zero	101

	/* #392 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555007
	/* java_name */
	.ascii	"java/lang/Throwable"
	.zero	98

	/* #393 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555035
	/* java_name */
	.ascii	"java/lang/UnsupportedOperationException"
	.zero	78

	/* #394 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555037
	/* java_name */
	.ascii	"java/lang/annotation/Annotation"
	.zero	86

	/* #395 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555039
	/* java_name */
	.ascii	"java/lang/reflect/AnnotatedElement"
	.zero	83

	/* #396 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555041
	/* java_name */
	.ascii	"java/lang/reflect/GenericDeclaration"
	.zero	81

	/* #397 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555043
	/* java_name */
	.ascii	"java/lang/reflect/Type"
	.zero	95

	/* #398 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555045
	/* java_name */
	.ascii	"java/lang/reflect/TypeVariable"
	.zero	87

	/* #399 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554907
	/* java_name */
	.ascii	"java/net/ConnectException"
	.zero	92

	/* #400 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554909
	/* java_name */
	.ascii	"java/net/HttpURLConnection"
	.zero	91

	/* #401 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554911
	/* java_name */
	.ascii	"java/net/InetSocketAddress"
	.zero	91

	/* #402 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554912
	/* java_name */
	.ascii	"java/net/Proxy"
	.zero	103

	/* #403 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554913
	/* java_name */
	.ascii	"java/net/Proxy$Type"
	.zero	98

	/* #404 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554914
	/* java_name */
	.ascii	"java/net/ProxySelector"
	.zero	95

	/* #405 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554916
	/* java_name */
	.ascii	"java/net/SocketAddress"
	.zero	95

	/* #406 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554918
	/* java_name */
	.ascii	"java/net/SocketException"
	.zero	93

	/* #407 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554919
	/* java_name */
	.ascii	"java/net/URI"
	.zero	105

	/* #408 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554920
	/* java_name */
	.ascii	"java/net/URL"
	.zero	105

	/* #409 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554921
	/* java_name */
	.ascii	"java/net/URLConnection"
	.zero	95

	/* #410 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554965
	/* java_name */
	.ascii	"java/nio/Buffer"
	.zero	102

	/* #411 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554967
	/* java_name */
	.ascii	"java/nio/ByteBuffer"
	.zero	98

	/* #412 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554972
	/* java_name */
	.ascii	"java/nio/channels/ByteChannel"
	.zero	88

	/* #413 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554974
	/* java_name */
	.ascii	"java/nio/channels/Channel"
	.zero	92

	/* #414 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554969
	/* java_name */
	.ascii	"java/nio/channels/FileChannel"
	.zero	88

	/* #415 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554976
	/* java_name */
	.ascii	"java/nio/channels/GatheringByteChannel"
	.zero	79

	/* #416 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554978
	/* java_name */
	.ascii	"java/nio/channels/InterruptibleChannel"
	.zero	79

	/* #417 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554980
	/* java_name */
	.ascii	"java/nio/channels/ReadableByteChannel"
	.zero	80

	/* #418 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554982
	/* java_name */
	.ascii	"java/nio/channels/ScatteringByteChannel"
	.zero	78

	/* #419 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554984
	/* java_name */
	.ascii	"java/nio/channels/SeekableByteChannel"
	.zero	80

	/* #420 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554986
	/* java_name */
	.ascii	"java/nio/channels/WritableByteChannel"
	.zero	80

	/* #421 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554987
	/* java_name */
	.ascii	"java/nio/channels/spi/AbstractInterruptibleChannel"
	.zero	67

	/* #422 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554934
	/* java_name */
	.ascii	"java/security/GeneralSecurityException"
	.zero	79

	/* #423 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554936
	/* java_name */
	.ascii	"java/security/Key"
	.zero	100

	/* #424 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554941
	/* java_name */
	.ascii	"java/security/KeyFactory"
	.zero	93

	/* #425 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554942
	/* java_name */
	.ascii	"java/security/KeyStore"
	.zero	95

	/* #426 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554944
	/* java_name */
	.ascii	"java/security/KeyStore$LoadStoreParameter"
	.zero	76

	/* #427 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554946
	/* java_name */
	.ascii	"java/security/KeyStore$ProtectionParameter"
	.zero	75

	/* #428 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554947
	/* java_name */
	.ascii	"java/security/NoSuchAlgorithmException"
	.zero	79

	/* #429 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554938
	/* java_name */
	.ascii	"java/security/Principal"
	.zero	94

	/* #430 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554940
	/* java_name */
	.ascii	"java/security/PublicKey"
	.zero	94

	/* #431 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554948
	/* java_name */
	.ascii	"java/security/SecureRandom"
	.zero	91

	/* #432 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554949
	/* java_name */
	.ascii	"java/security/Signature"
	.zero	94

	/* #433 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554951
	/* java_name */
	.ascii	"java/security/SignatureSpi"
	.zero	91

	/* #434 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554958
	/* java_name */
	.ascii	"java/security/cert/Certificate"
	.zero	87

	/* #435 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554960
	/* java_name */
	.ascii	"java/security/cert/CertificateFactory"
	.zero	80

	/* #436 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554963
	/* java_name */
	.ascii	"java/security/cert/X509Certificate"
	.zero	83

	/* #437 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554962
	/* java_name */
	.ascii	"java/security/cert/X509Extension"
	.zero	85

	/* #438 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554953
	/* java_name */
	.ascii	"java/security/spec/EncodedKeySpec"
	.zero	84

	/* #439 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554956
	/* java_name */
	.ascii	"java/security/spec/KeySpec"
	.zero	91

	/* #440 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554957
	/* java_name */
	.ascii	"java/security/spec/X509EncodedKeySpec"
	.zero	80

	/* #441 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554875
	/* java_name */
	.ascii	"java/util/ArrayList"
	.zero	98

	/* #442 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554864
	/* java_name */
	.ascii	"java/util/Collection"
	.zero	97

	/* #443 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554923
	/* java_name */
	.ascii	"java/util/Date"
	.zero	103

	/* #444 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554925
	/* java_name */
	.ascii	"java/util/Enumeration"
	.zero	96

	/* #445 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554866
	/* java_name */
	.ascii	"java/util/HashMap"
	.zero	100

	/* #446 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554884
	/* java_name */
	.ascii	"java/util/HashSet"
	.zero	100

	/* #447 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554927
	/* java_name */
	.ascii	"java/util/Iterator"
	.zero	99

	/* #448 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554928
	/* java_name */
	.ascii	"java/util/Random"
	.zero	101

	/* #449 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554930
	/* java_name */
	.ascii	"java/util/concurrent/Executor"
	.zero	88

	/* #450 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554932
	/* java_name */
	.ascii	"java/util/concurrent/Future"
	.zero	90

	/* #451 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554933
	/* java_name */
	.ascii	"java/util/concurrent/TimeUnit"
	.zero	88

	/* #452 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554464
	/* java_name */
	.ascii	"javax/net/SocketFactory"
	.zero	94

	/* #453 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554469
	/* java_name */
	.ascii	"javax/net/ssl/HostnameVerifier"
	.zero	87

	/* #454 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554466
	/* java_name */
	.ascii	"javax/net/ssl/HttpsURLConnection"
	.zero	85

	/* #455 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554471
	/* java_name */
	.ascii	"javax/net/ssl/KeyManager"
	.zero	93

	/* #456 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554480
	/* java_name */
	.ascii	"javax/net/ssl/KeyManagerFactory"
	.zero	86

	/* #457 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554481
	/* java_name */
	.ascii	"javax/net/ssl/SSLContext"
	.zero	93

	/* #458 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554473
	/* java_name */
	.ascii	"javax/net/ssl/SSLSession"
	.zero	93

	/* #459 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554475
	/* java_name */
	.ascii	"javax/net/ssl/SSLSessionContext"
	.zero	86

	/* #460 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554482
	/* java_name */
	.ascii	"javax/net/ssl/SSLSocketFactory"
	.zero	87

	/* #461 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554477
	/* java_name */
	.ascii	"javax/net/ssl/TrustManager"
	.zero	91

	/* #462 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554484
	/* java_name */
	.ascii	"javax/net/ssl/TrustManagerFactory"
	.zero	84

	/* #463 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554479
	/* java_name */
	.ascii	"javax/net/ssl/X509TrustManager"
	.zero	87

	/* #464 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554460
	/* java_name */
	.ascii	"javax/security/cert/Certificate"
	.zero	86

	/* #465 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554462
	/* java_name */
	.ascii	"javax/security/cert/X509Certificate"
	.zero	82

	/* #466 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555085
	/* java_name */
	.ascii	"mono/android/TypeManager"
	.zero	93

	/* #467 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554806
	/* java_name */
	.ascii	"mono/android/content/DialogInterface_OnClickListenerImplementor"
	.zero	54

	/* #468 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554809
	/* java_name */
	.ascii	"mono/android/content/DialogInterface_OnDismissListenerImplementor"
	.zero	52

	/* #469 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554860
	/* java_name */
	.ascii	"mono/android/runtime/InputStreamAdapter"
	.zero	78

	/* #470 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"mono/android/runtime/JavaArray"
	.zero	87

	/* #471 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554881
	/* java_name */
	.ascii	"mono/android/runtime/JavaObject"
	.zero	86

	/* #472 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554899
	/* java_name */
	.ascii	"mono/android/runtime/OutputStreamAdapter"
	.zero	77

	/* #473 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554646
	/* java_name */
	.ascii	"mono/android/text/TextWatcherImplementor"
	.zero	77

	/* #474 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554532
	/* java_name */
	.ascii	"mono/android/view/View_OnClickListenerImplementor"
	.zero	68

	/* #475 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554538
	/* java_name */
	.ascii	"mono/android/view/View_OnTouchListenerImplementor"
	.zero	68

	/* #476 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554503
	/* java_name */
	.ascii	"mono/android/widget/TextView_OnEditorActionListenerImplementor"
	.zero	55

	/* #477 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554441
	/* java_name */
	.ascii	"mono/androidx/appcompat/app/ActionBar_OnMenuVisibilityListenerImplementor"
	.zero	44

	/* #478 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554467
	/* java_name */
	.ascii	"mono/androidx/appcompat/widget/Toolbar_OnMenuItemClickListenerImplementor"
	.zero	44

	/* #479 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554444
	/* java_name */
	.ascii	"mono/androidx/core/view/ActionProvider_SubUiVisibilityListenerImplementor"
	.zero	44

	/* #480 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554448
	/* java_name */
	.ascii	"mono/androidx/core/view/ActionProvider_VisibilityListenerImplementor"
	.zero	49

	/* #481 */
	/* module_index */
	.long	10
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"mono/androidx/drawerlayout/widget/DrawerLayout_DrawerListenerImplementor"
	.zero	45

	/* #482 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554447
	/* java_name */
	.ascii	"mono/androidx/fragment/app/FragmentManager_OnBackStackChangedListenerImplementor"
	.zero	37

	/* #483 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"mono/com/google/android/material/behavior/SwipeDismissBehavior_OnDismissListenerImplementor"
	.zero	26

	/* #484 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554456
	/* java_name */
	.ascii	"mono/com/google/android/material/bottomnavigation/BottomNavigationView_OnNavigationItemReselectedListenerImplementor"
	.zero	1

	/* #485 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554460
	/* java_name */
	.ascii	"mono/com/google/android/material/bottomnavigation/BottomNavigationView_OnNavigationItemSelectedListenerImplementor"
	.zero	3

	/* #486 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33555006
	/* java_name */
	.ascii	"mono/java/lang/RunnableImplementor"
	.zero	83

	/* #487 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554456
	/* java_name */
	.ascii	"xamarin/android/net/OldAndroidSSLSocketFactory"
	.zero	71

	/* #488 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554460
	/* java_name */
	.ascii	"xamarin/essentials/fileProvider"
	.zero	86

	.size	map_java, 61125
/* Java to managed map: END */

