	.file	"typemaps.x86_64.s"

/* map_module_count: START */
	.section	.rodata.map_module_count,"a",@progbits
	.type	map_module_count, @object
	.p2align	2
	.global	map_module_count
map_module_count:
	.size	map_module_count, 4
	.long	26
/* map_module_count: END */

/* java_type_count: START */
	.section	.rodata.java_type_count,"a",@progbits
	.type	java_type_count, @object
	.p2align	2
	.global	java_type_count
java_type_count:
	.size	java_type_count, 4
	.long	795
/* java_type_count: END */

/* java_name_width: START */
	.section	.rodata.java_name_width,"a",@progbits
	.type	java_name_width, @object
	.p2align	2
	.global	java_name_width
java_name_width:
	.size	java_name_width, 4
	.long	117
/* java_name_width: END */

	.include	"typemaps.shared.inc"
	.include	"typemaps.x86_64-managed.inc"

/* Managed to Java map: START */
	.section	.data.rel.map_modules,"aw",@progbits
	.type	map_modules, @object
	.p2align	4
	.global	map_modules
map_modules:
	/* module_uuid: 4899ad11-6dc5-4c49-bc25-1d5332f6587e */
	.byte	0x11, 0xad, 0x99, 0x48, 0xc5, 0x6d, 0x49, 0x4c, 0xbc, 0x25, 0x1d, 0x53, 0x32, 0xf6, 0x58, 0x7e
	/* entry_count */
	.long	3
	/* duplicate_count */
	.long	1
	/* map */
	.quad	module0_managed_to_java
	/* duplicate_map */
	.quad	module0_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.CoordinatorLayout */
	.quad	.L.map_aname.0
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 59210923-e675-48cc-8553-14c494ef79f6 */
	.byte	0x23, 0x09, 0x21, 0x59, 0x75, 0xe6, 0xcc, 0x48, 0x85, 0x53, 0x14, 0xc4, 0x94, 0xef, 0x79, 0xf6
	/* entry_count */
	.long	1
	/* duplicate_count */
	.long	0
	/* map */
	.quad	module1_managed_to_java
	/* duplicate_map */
	.quad	0
	/* assembly_name: Plugin.CurrentActivity */
	.quad	.L.map_aname.1
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 2f0bf323-1637-421b-b4b3-90d36e2e2844 */
	.byte	0x23, 0xf3, 0x0b, 0x2f, 0x37, 0x16, 0x1b, 0x42, 0xb4, 0xb3, 0x90, 0xd3, 0x6e, 0x2e, 0x28, 0x44
	/* entry_count */
	.long	4
	/* duplicate_count */
	.long	1
	/* map */
	.quad	module2_managed_to_java
	/* duplicate_map */
	.quad	module2_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Lifecycle.Common */
	.quad	.L.map_aname.2
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 76387d2b-9a45-4205-b132-a27e46852927 */
	.byte	0x2b, 0x7d, 0x38, 0x76, 0x45, 0x9a, 0x05, 0x42, 0xb1, 0x32, 0xa2, 0x7e, 0x46, 0x85, 0x29, 0x27
	/* entry_count */
	.long	366
	/* duplicate_count */
	.long	57
	/* map */
	.quad	module3_managed_to_java
	/* duplicate_map */
	.quad	module3_managed_to_java_duplicates
	/* assembly_name: Mono.Android */
	.quad	.L.map_aname.3
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 84e66c33-ad57-4ee2-a51b-3725b23603cf */
	.byte	0x33, 0x6c, 0xe6, 0x84, 0x57, 0xad, 0xe2, 0x4e, 0xa5, 0x1b, 0x37, 0x25, 0xb2, 0x36, 0x03, 0xcf
	/* entry_count */
	.long	1
	/* duplicate_count */
	.long	0
	/* map */
	.quad	module4_managed_to_java
	/* duplicate_map */
	.quad	0
	/* assembly_name: Xamarin.AndroidX.CardView */
	.quad	.L.map_aname.4
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 4a8f2f38-ee52-4322-9d49-42667a03a953 */
	.byte	0x38, 0x2f, 0x8f, 0x4a, 0x52, 0xee, 0x22, 0x43, 0x9d, 0x49, 0x42, 0x66, 0x7a, 0x03, 0xa9, 0x53
	/* entry_count */
	.long	4
	/* duplicate_count */
	.long	1
	/* map */
	.quad	module5_managed_to_java
	/* duplicate_map */
	.quad	module5_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Activity */
	.quad	.L.map_aname.5
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 127b243f-6199-471d-b262-83767919b1a8 */
	.byte	0x3f, 0x24, 0x7b, 0x12, 0x99, 0x61, 0x1d, 0x47, 0xb2, 0x62, 0x83, 0x76, 0x79, 0x19, 0xb1, 0xa8
	/* entry_count */
	.long	42
	/* duplicate_count */
	.long	13
	/* map */
	.quad	module6_managed_to_java
	/* duplicate_map */
	.quad	module6_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.RecyclerView */
	.quad	.L.map_aname.6
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 1548d343-64a0-4afa-b6ec-1b6550583298 */
	.byte	0x43, 0xd3, 0x48, 0x15, 0xa0, 0x64, 0xfa, 0x4a, 0xb6, 0xec, 0x1b, 0x65, 0x50, 0x58, 0x32, 0x98
	/* entry_count */
	.long	11
	/* duplicate_count */
	.long	2
	/* map */
	.quad	module7_managed_to_java
	/* duplicate_map */
	.quad	module7_managed_to_java_duplicates
	/* assembly_name: Xamarin.GooglePlayServices.Tasks */
	.quad	.L.map_aname.7
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: eebdeb47-45c6-495f-961f-fb879ab42f8a */
	.byte	0x47, 0xeb, 0xbd, 0xee, 0xc6, 0x45, 0x5f, 0x49, 0x96, 0x1f, 0xfb, 0x87, 0x9a, 0xb4, 0x2f, 0x8a
	/* entry_count */
	.long	25
	/* duplicate_count */
	.long	0
	/* map */
	.quad	module8_managed_to_java
	/* duplicate_map */
	.quad	0
	/* assembly_name: Squelch */
	.quad	.L.map_aname.8
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 9a1b995c-f090-4cbe-a0e6-49af835841cf */
	.byte	0x5c, 0x99, 0x1b, 0x9a, 0x90, 0xf0, 0xbe, 0x4c, 0xa0, 0xe6, 0x49, 0xaf, 0x83, 0x58, 0x41, 0xcf
	/* entry_count */
	.long	11
	/* duplicate_count */
	.long	3
	/* map */
	.quad	module9_managed_to_java
	/* duplicate_map */
	.quad	module9_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Fragment */
	.quad	.L.map_aname.9
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 2322745d-f0a8-4f26-8de2-64b2bd4e192d */
	.byte	0x5d, 0x74, 0x22, 0x23, 0xa8, 0xf0, 0x26, 0x4f, 0x8d, 0xe2, 0x64, 0xb2, 0xbd, 0x4e, 0x19, 0x2d
	/* entry_count */
	.long	3
	/* duplicate_count */
	.long	0
	/* map */
	.quad	module10_managed_to_java
	/* duplicate_map */
	.quad	0
	/* assembly_name: Xamarin.AndroidX.DrawerLayout */
	.quad	.L.map_aname.10
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: c57c3374-06aa-4c11-ba3b-a087a28f636a */
	.byte	0x74, 0x33, 0x7c, 0xc5, 0xaa, 0x06, 0x11, 0x4c, 0xba, 0x3b, 0xa0, 0x87, 0xa2, 0x8f, 0x63, 0x6a
	/* entry_count */
	.long	2
	/* duplicate_count */
	.long	1
	/* map */
	.quad	module11_managed_to_java
	/* duplicate_map */
	.quad	module11_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.VersionedParcelable */
	.quad	.L.map_aname.11
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 7b118c77-2058-4a89-b4c5-f6f2d09c4cfc */
	.byte	0x77, 0x8c, 0x11, 0x7b, 0x58, 0x20, 0x89, 0x4a, 0xb4, 0xc5, 0xf6, 0xf2, 0xd0, 0x9c, 0x4c, 0xfc
	/* entry_count */
	.long	2
	/* duplicate_count */
	.long	1
	/* map */
	.quad	module12_managed_to_java
	/* duplicate_map */
	.quad	module12_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Lifecycle.LiveData.Core */
	.quad	.L.map_aname.12
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 2ecb4f83-8e1b-46db-abe7-2c1476414441 */
	.byte	0x83, 0x4f, 0xcb, 0x2e, 0x1b, 0x8e, 0xdb, 0x46, 0xab, 0xe7, 0x2c, 0x14, 0x76, 0x41, 0x44, 0x41
	/* entry_count */
	.long	2
	/* duplicate_count */
	.long	0
	/* map */
	.quad	module13_managed_to_java
	/* duplicate_map */
	.quad	0
	/* assembly_name: Xamarin.Essentials */
	.quad	.L.map_aname.13
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 1e279a83-e238-4729-a628-55710bec57f8 */
	.byte	0x83, 0x9a, 0x27, 0x1e, 0x38, 0xe2, 0x29, 0x47, 0xa6, 0x28, 0x55, 0x71, 0x0b, 0xec, 0x57, 0xf8
	/* entry_count */
	.long	3
	/* duplicate_count */
	.long	0
	/* map */
	.quad	module14_managed_to_java
	/* duplicate_map */
	.quad	0
	/* assembly_name: Xamarin.AndroidX.SavedState */
	.quad	.L.map_aname.14
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 0ba5b886-07ed-49d0-8982-96621ce56c3d */
	.byte	0x86, 0xb8, 0xa5, 0x0b, 0xed, 0x07, 0xd0, 0x49, 0x89, 0x82, 0x96, 0x62, 0x1c, 0xe5, 0x6c, 0x3d
	/* entry_count */
	.long	32
	/* duplicate_count */
	.long	4
	/* map */
	.quad	module15_managed_to_java
	/* duplicate_map */
	.quad	module15_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.AppCompat */
	.quad	.L.map_aname.15
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 2be3ca88-0762-42b5-875e-211410fe2dd3 */
	.byte	0x88, 0xca, 0xe3, 0x2b, 0x62, 0x07, 0xb5, 0x42, 0x87, 0x5e, 0x21, 0x14, 0x10, 0xfe, 0x2d, 0xd3
	/* entry_count */
	.long	1
	/* duplicate_count */
	.long	0
	/* map */
	.quad	module16_managed_to_java
	/* duplicate_map */
	.quad	0
	/* assembly_name: Plugin.InAppBilling */
	.quad	.L.map_aname.16
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 1b933b98-402c-41f7-a183-b13ed447b350 */
	.byte	0x98, 0x3b, 0x93, 0x1b, 0x2c, 0x40, 0xf7, 0x41, 0xa1, 0x83, 0xb1, 0x3e, 0xd4, 0x47, 0xb3, 0x50
	/* entry_count */
	.long	65
	/* duplicate_count */
	.long	4
	/* map */
	.quad	module17_managed_to_java
	/* duplicate_map */
	.quad	module17_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Core */
	.quad	.L.map_aname.17
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 98922c9b-781e-4516-9373-1daf2f341399 */
	.byte	0x9b, 0x2c, 0x92, 0x98, 0x1e, 0x78, 0x16, 0x45, 0x93, 0x73, 0x1d, 0xaf, 0x2f, 0x34, 0x13, 0x99
	/* entry_count */
	.long	2
	/* duplicate_count */
	.long	0
	/* map */
	.quad	module18_managed_to_java
	/* duplicate_map */
	.quad	0
	/* assembly_name: Xamarin.AndroidX.Lifecycle.ViewModel */
	.quad	.L.map_aname.18
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: d25befab-bad2-48a0-b45b-b9fd0dd4eb8c */
	.byte	0xab, 0xef, 0x5b, 0xd2, 0xd2, 0xba, 0xa0, 0x48, 0xb4, 0x5b, 0xb9, 0xfd, 0x0d, 0xd4, 0xeb, 0x8c
	/* entry_count */
	.long	6
	/* duplicate_count */
	.long	0
	/* map */
	.quad	module19_managed_to_java
	/* duplicate_map */
	.quad	0
	/* assembly_name: Xamarin.Google.AutoValue.Annotations */
	.quad	.L.map_aname.19
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 6aaf78b4-9a77-4685-8828-22d9d341377b */
	.byte	0xb4, 0x78, 0xaf, 0x6a, 0x77, 0x9a, 0x85, 0x46, 0x88, 0x28, 0x22, 0xd9, 0xd3, 0x41, 0x37, 0x7b
	/* entry_count */
	.long	1
	/* duplicate_count */
	.long	0
	/* map */
	.quad	module20_managed_to_java
	/* duplicate_map */
	.quad	0
	/* assembly_name: Xamarin.GooglePlayServices.Measurement.Api */
	.quad	.L.map_aname.20
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 5cf4ccd7-6f67-4b45-b3be-a7ba37ba0b38 */
	.byte	0xd7, 0xcc, 0xf4, 0x5c, 0x67, 0x6f, 0x45, 0x4b, 0xb3, 0xbe, 0xa7, 0xba, 0x37, 0xba, 0x0b, 0x38
	/* entry_count */
	.long	2
	/* duplicate_count */
	.long	0
	/* map */
	.quad	module21_managed_to_java
	/* duplicate_map */
	.quad	0
	/* assembly_name: Plugin.InAppBilling.VendingLibrary */
	.quad	.L.map_aname.21
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 1e3516d8-6fa4-4445-baa1-801725c44a59 */
	.byte	0xd8, 0x16, 0x35, 0x1e, 0xa4, 0x6f, 0x45, 0x44, 0xba, 0xa1, 0x80, 0x17, 0x25, 0xc4, 0x4a, 0x59
	/* entry_count */
	.long	177
	/* duplicate_count */
	.long	26
	/* map */
	.quad	module22_managed_to_java
	/* duplicate_map */
	.quad	module22_managed_to_java_duplicates
	/* assembly_name: library-mpandroidchart */
	.quad	.L.map_aname.22
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 22ab85d9-c40c-4739-b6fe-c7ac6cfd022e */
	.byte	0xd9, 0x85, 0xab, 0x22, 0x0c, 0xc4, 0x39, 0x47, 0xb6, 0xfe, 0xc7, 0xac, 0x6c, 0xfd, 0x02, 0x2e
	/* entry_count */
	.long	1
	/* duplicate_count */
	.long	0
	/* map */
	.quad	module23_managed_to_java
	/* duplicate_map */
	.quad	0
	/* assembly_name: Xamarin.Google.Guava.ListenableFuture */
	.quad	.L.map_aname.23
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: 2ebb27e6-77f1-4a85-9754-4a5c1efac1ac */
	.byte	0xe6, 0x27, 0xbb, 0x2e, 0xf1, 0x77, 0x85, 0x4a, 0x97, 0x54, 0x4a, 0x5c, 0x1e, 0xfa, 0xc1, 0xac
	/* entry_count */
	.long	23
	/* duplicate_count */
	.long	3
	/* map */
	.quad	module24_managed_to_java
	/* duplicate_map */
	.quad	module24_managed_to_java_duplicates
	/* assembly_name: Xamarin.Google.Android.Material */
	.quad	.L.map_aname.24
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	/* module_uuid: f54a74eb-880d-4c76-9e44-db939b7e6dd2 */
	.byte	0xeb, 0x74, 0x4a, 0xf5, 0x0d, 0x88, 0x76, 0x4c, 0x9e, 0x44, 0xdb, 0x93, 0x9b, 0x7e, 0x6d, 0xd2
	/* entry_count */
	.long	5
	/* duplicate_count */
	.long	1
	/* map */
	.quad	module25_managed_to_java
	/* duplicate_map */
	.quad	module25_managed_to_java_duplicates
	/* assembly_name: Xamarin.AndroidX.Loader */
	.quad	.L.map_aname.25
	/* image */
	.quad	0
	/* java_name_width */
	.long	0
	/* java_map */
	.zero	4
	.quad	0

	.size	map_modules, 1872
/* Managed to Java map: END */

/* Java to managed map: START */
	.section	.rodata.map_java,"a",@progbits
	.type	map_java, @object
	.p2align	4
	.global	map_java
map_java:
	/* #0 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554776
	/* java_name */
	.ascii	"android/animation/Animator"
	.zero	91

	/* #1 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554778
	/* java_name */
	.ascii	"android/animation/Animator$AnimatorListener"
	.zero	74

	/* #2 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554780
	/* java_name */
	.ascii	"android/animation/Animator$AnimatorPauseListener"
	.zero	69

	/* #3 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554782
	/* java_name */
	.ascii	"android/animation/AnimatorListenerAdapter"
	.zero	76

	/* #4 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554786
	/* java_name */
	.ascii	"android/animation/ObjectAnimator"
	.zero	85

	/* #5 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554785
	/* java_name */
	.ascii	"android/animation/TimeInterpolator"
	.zero	83

	/* #6 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554787
	/* java_name */
	.ascii	"android/animation/ValueAnimator"
	.zero	86

	/* #7 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554789
	/* java_name */
	.ascii	"android/animation/ValueAnimator$AnimatorUpdateListener"
	.zero	63

	/* #8 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554793
	/* java_name */
	.ascii	"android/app/Activity"
	.zero	97

	/* #9 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554794
	/* java_name */
	.ascii	"android/app/ActivityManager"
	.zero	90

	/* #10 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554795
	/* java_name */
	.ascii	"android/app/ActivityManager$RunningAppProcessInfo"
	.zero	68

	/* #11 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554796
	/* java_name */
	.ascii	"android/app/AlertDialog"
	.zero	94

	/* #12 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554797
	/* java_name */
	.ascii	"android/app/AlertDialog$Builder"
	.zero	86

	/* #13 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554801
	/* java_name */
	.ascii	"android/app/AppOpsManager"
	.zero	92

	/* #14 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554798
	/* java_name */
	.ascii	"android/app/Application"
	.zero	94

	/* #15 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554800
	/* java_name */
	.ascii	"android/app/Application$ActivityLifecycleCallbacks"
	.zero	67

	/* #16 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554802
	/* java_name */
	.ascii	"android/app/DatePickerDialog"
	.zero	89

	/* #17 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554804
	/* java_name */
	.ascii	"android/app/DatePickerDialog$OnDateSetListener"
	.zero	71

	/* #18 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554805
	/* java_name */
	.ascii	"android/app/Dialog"
	.zero	99

	/* #19 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554808
	/* java_name */
	.ascii	"android/app/Notification"
	.zero	93

	/* #20 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554809
	/* java_name */
	.ascii	"android/app/Notification$Builder"
	.zero	85

	/* #21 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554810
	/* java_name */
	.ascii	"android/app/NotificationChannel"
	.zero	86

	/* #22 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554811
	/* java_name */
	.ascii	"android/app/NotificationManager"
	.zero	86

	/* #23 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554812
	/* java_name */
	.ascii	"android/app/PendingIntent"
	.zero	92

	/* #24 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554813
	/* java_name */
	.ascii	"android/app/Service"
	.zero	98

	/* #25 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554815
	/* java_name */
	.ascii	"android/app/TimePickerDialog"
	.zero	89

	/* #26 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554817
	/* java_name */
	.ascii	"android/app/TimePickerDialog$OnTimeSetListener"
	.zero	71

	/* #27 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554832
	/* java_name */
	.ascii	"android/app/usage/UsageEvents"
	.zero	88

	/* #28 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554833
	/* java_name */
	.ascii	"android/app/usage/UsageEvents$Event"
	.zero	82

	/* #29 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554834
	/* java_name */
	.ascii	"android/app/usage/UsageStatsManager"
	.zero	82

	/* #30 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554838
	/* java_name */
	.ascii	"android/content/BroadcastReceiver"
	.zero	84

	/* #31 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554841
	/* java_name */
	.ascii	"android/content/ClipData"
	.zero	93

	/* #32 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554840
	/* java_name */
	.ascii	"android/content/ClipboardManager"
	.zero	85

	/* #33 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554852
	/* java_name */
	.ascii	"android/content/ComponentCallbacks"
	.zero	83

	/* #34 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554854
	/* java_name */
	.ascii	"android/content/ComponentCallbacks2"
	.zero	82

	/* #35 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554842
	/* java_name */
	.ascii	"android/content/ComponentName"
	.zero	88

	/* #36 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554843
	/* java_name */
	.ascii	"android/content/ContentProvider"
	.zero	86

	/* #37 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554845
	/* java_name */
	.ascii	"android/content/ContentResolver"
	.zero	86

	/* #38 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554847
	/* java_name */
	.ascii	"android/content/ContentValues"
	.zero	88

	/* #39 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554848
	/* java_name */
	.ascii	"android/content/Context"
	.zero	94

	/* #40 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554850
	/* java_name */
	.ascii	"android/content/ContextWrapper"
	.zero	87

	/* #41 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554863
	/* java_name */
	.ascii	"android/content/DialogInterface"
	.zero	86

	/* #42 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554856
	/* java_name */
	.ascii	"android/content/DialogInterface$OnCancelListener"
	.zero	69

	/* #43 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554858
	/* java_name */
	.ascii	"android/content/DialogInterface$OnClickListener"
	.zero	70

	/* #44 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554860
	/* java_name */
	.ascii	"android/content/DialogInterface$OnDismissListener"
	.zero	68

	/* #45 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554864
	/* java_name */
	.ascii	"android/content/Intent"
	.zero	95

	/* #46 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554865
	/* java_name */
	.ascii	"android/content/IntentFilter"
	.zero	89

	/* #47 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554866
	/* java_name */
	.ascii	"android/content/IntentSender"
	.zero	89

	/* #48 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554868
	/* java_name */
	.ascii	"android/content/ServiceConnection"
	.zero	84

	/* #49 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554874
	/* java_name */
	.ascii	"android/content/SharedPreferences"
	.zero	84

	/* #50 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554870
	/* java_name */
	.ascii	"android/content/SharedPreferences$Editor"
	.zero	77

	/* #51 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554872
	/* java_name */
	.ascii	"android/content/SharedPreferences$OnSharedPreferenceChangeListener"
	.zero	51

	/* #52 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554885
	/* java_name */
	.ascii	"android/content/pm/ApplicationInfo"
	.zero	83

	/* #53 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554886
	/* java_name */
	.ascii	"android/content/pm/PackageInfo"
	.zero	87

	/* #54 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554887
	/* java_name */
	.ascii	"android/content/pm/PackageItemInfo"
	.zero	83

	/* #55 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554888
	/* java_name */
	.ascii	"android/content/pm/PackageManager"
	.zero	84

	/* #56 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554890
	/* java_name */
	.ascii	"android/content/pm/ResolveInfo"
	.zero	87

	/* #57 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554879
	/* java_name */
	.ascii	"android/content/res/AssetManager"
	.zero	85

	/* #58 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554880
	/* java_name */
	.ascii	"android/content/res/ColorStateList"
	.zero	83

	/* #59 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554881
	/* java_name */
	.ascii	"android/content/res/Configuration"
	.zero	84

	/* #60 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554882
	/* java_name */
	.ascii	"android/content/res/Resources"
	.zero	88

	/* #61 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554883
	/* java_name */
	.ascii	"android/content/res/Resources$Theme"
	.zero	82

	/* #62 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554884
	/* java_name */
	.ascii	"android/content/res/TypedArray"
	.zero	87

	/* #63 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554768
	/* java_name */
	.ascii	"android/database/CharArrayBuffer"
	.zero	85

	/* #64 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554769
	/* java_name */
	.ascii	"android/database/ContentObserver"
	.zero	85

	/* #65 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554774
	/* java_name */
	.ascii	"android/database/Cursor"
	.zero	94

	/* #66 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554771
	/* java_name */
	.ascii	"android/database/DataSetObserver"
	.zero	85

	/* #67 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554735
	/* java_name */
	.ascii	"android/graphics/Bitmap"
	.zero	94

	/* #68 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554736
	/* java_name */
	.ascii	"android/graphics/Bitmap$CompressFormat"
	.zero	79

	/* #69 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554737
	/* java_name */
	.ascii	"android/graphics/Bitmap$Config"
	.zero	87

	/* #70 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554738
	/* java_name */
	.ascii	"android/graphics/BitmapFactory"
	.zero	87

	/* #71 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554739
	/* java_name */
	.ascii	"android/graphics/Canvas"
	.zero	94

	/* #72 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554741
	/* java_name */
	.ascii	"android/graphics/Color"
	.zero	95

	/* #73 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554740
	/* java_name */
	.ascii	"android/graphics/ColorFilter"
	.zero	89

	/* #74 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554742
	/* java_name */
	.ascii	"android/graphics/DashPathEffect"
	.zero	86

	/* #75 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554743
	/* java_name */
	.ascii	"android/graphics/Matrix"
	.zero	94

	/* #76 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554744
	/* java_name */
	.ascii	"android/graphics/Paint"
	.zero	95

	/* #77 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554745
	/* java_name */
	.ascii	"android/graphics/Paint$Align"
	.zero	89

	/* #78 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554746
	/* java_name */
	.ascii	"android/graphics/Paint$FontMetrics"
	.zero	83

	/* #79 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554747
	/* java_name */
	.ascii	"android/graphics/Paint$Style"
	.zero	89

	/* #80 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554748
	/* java_name */
	.ascii	"android/graphics/Path"
	.zero	96

	/* #81 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554749
	/* java_name */
	.ascii	"android/graphics/PathEffect"
	.zero	90

	/* #82 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554750
	/* java_name */
	.ascii	"android/graphics/Point"
	.zero	95

	/* #83 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554751
	/* java_name */
	.ascii	"android/graphics/PointF"
	.zero	94

	/* #84 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554752
	/* java_name */
	.ascii	"android/graphics/PorterDuff"
	.zero	90

	/* #85 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554753
	/* java_name */
	.ascii	"android/graphics/PorterDuff$Mode"
	.zero	85

	/* #86 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554754
	/* java_name */
	.ascii	"android/graphics/Rect"
	.zero	96

	/* #87 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554755
	/* java_name */
	.ascii	"android/graphics/RectF"
	.zero	95

	/* #88 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554756
	/* java_name */
	.ascii	"android/graphics/Region"
	.zero	94

	/* #89 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554757
	/* java_name */
	.ascii	"android/graphics/Typeface"
	.zero	92

	/* #90 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554763
	/* java_name */
	.ascii	"android/graphics/drawable/Drawable"
	.zero	83

	/* #91 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554765
	/* java_name */
	.ascii	"android/graphics/drawable/Drawable$Callback"
	.zero	74

	/* #92 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554767
	/* java_name */
	.ascii	"android/graphics/drawable/Icon"
	.zero	87

	/* #93 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554733
	/* java_name */
	.ascii	"android/net/Uri"
	.zero	102

	/* #94 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554710
	/* java_name */
	.ascii	"android/os/BaseBundle"
	.zero	96

	/* #95 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554711
	/* java_name */
	.ascii	"android/os/Binder"
	.zero	100

	/* #96 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554712
	/* java_name */
	.ascii	"android/os/Build"
	.zero	101

	/* #97 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554713
	/* java_name */
	.ascii	"android/os/Build$VERSION"
	.zero	93

	/* #98 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554714
	/* java_name */
	.ascii	"android/os/Bundle"
	.zero	100

	/* #99 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554715
	/* java_name */
	.ascii	"android/os/Environment"
	.zero	95

	/* #100 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554716
	/* java_name */
	.ascii	"android/os/Handler"
	.zero	99

	/* #101 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554720
	/* java_name */
	.ascii	"android/os/IBinder"
	.zero	99

	/* #102 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554718
	/* java_name */
	.ascii	"android/os/IBinder$DeathRecipient"
	.zero	84

	/* #103 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554722
	/* java_name */
	.ascii	"android/os/IInterface"
	.zero	96

	/* #104 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554727
	/* java_name */
	.ascii	"android/os/Looper"
	.zero	100

	/* #105 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554728
	/* java_name */
	.ascii	"android/os/Parcel"
	.zero	100

	/* #106 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554726
	/* java_name */
	.ascii	"android/os/Parcelable"
	.zero	96

	/* #107 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554724
	/* java_name */
	.ascii	"android/os/Parcelable$Creator"
	.zero	88

	/* #108 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554729
	/* java_name */
	.ascii	"android/os/Process"
	.zero	99

	/* #109 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554709
	/* java_name */
	.ascii	"android/preference/PreferenceManager"
	.zero	81

	/* #110 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554941
	/* java_name */
	.ascii	"android/runtime/JavaProxyThrowable"
	.zero	83

	/* #111 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554664
	/* java_name */
	.ascii	"android/text/ClipboardManager"
	.zero	88

	/* #112 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554668
	/* java_name */
	.ascii	"android/text/Editable"
	.zero	96

	/* #113 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554671
	/* java_name */
	.ascii	"android/text/GetChars"
	.zero	96

	/* #114 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554666
	/* java_name */
	.ascii	"android/text/Html"
	.zero	100

	/* #115 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554674
	/* java_name */
	.ascii	"android/text/InputFilter"
	.zero	93

	/* #116 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554687
	/* java_name */
	.ascii	"android/text/Layout"
	.zero	98

	/* #117 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554676
	/* java_name */
	.ascii	"android/text/NoCopySpan"
	.zero	94

	/* #118 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554678
	/* java_name */
	.ascii	"android/text/Spannable"
	.zero	95

	/* #119 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554681
	/* java_name */
	.ascii	"android/text/Spanned"
	.zero	97

	/* #120 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554689
	/* java_name */
	.ascii	"android/text/StaticLayout"
	.zero	92

	/* #121 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554684
	/* java_name */
	.ascii	"android/text/TextDirectionHeuristic"
	.zero	82

	/* #122 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554690
	/* java_name */
	.ascii	"android/text/TextPaint"
	.zero	95

	/* #123 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554686
	/* java_name */
	.ascii	"android/text/TextWatcher"
	.zero	93

	/* #124 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554708
	/* java_name */
	.ascii	"android/text/format/DateFormat"
	.zero	87

	/* #125 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554703
	/* java_name */
	.ascii	"android/text/method/BaseMovementMethod"
	.zero	79

	/* #126 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554706
	/* java_name */
	.ascii	"android/text/method/LinkMovementMethod"
	.zero	79

	/* #127 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554705
	/* java_name */
	.ascii	"android/text/method/MovementMethod"
	.zero	83

	/* #128 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554707
	/* java_name */
	.ascii	"android/text/method/ScrollingMovementMethod"
	.zero	74

	/* #129 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554697
	/* java_name */
	.ascii	"android/text/style/CharacterStyle"
	.zero	84

	/* #130 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554699
	/* java_name */
	.ascii	"android/text/style/ClickableSpan"
	.zero	85

	/* #131 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554702
	/* java_name */
	.ascii	"android/text/style/UpdateAppearance"
	.zero	82

	/* #132 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554658
	/* java_name */
	.ascii	"android/util/AttributeSet"
	.zero	92

	/* #133 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554655
	/* java_name */
	.ascii	"android/util/Base64"
	.zero	98

	/* #134 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554656
	/* java_name */
	.ascii	"android/util/DisplayMetrics"
	.zero	90

	/* #135 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554659
	/* java_name */
	.ascii	"android/util/Log"
	.zero	101

	/* #136 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554660
	/* java_name */
	.ascii	"android/util/SparseArray"
	.zero	93

	/* #137 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554661
	/* java_name */
	.ascii	"android/util/TypedValue"
	.zero	94

	/* #138 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554537
	/* java_name */
	.ascii	"android/view/ActionMode"
	.zero	94

	/* #139 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554539
	/* java_name */
	.ascii	"android/view/ActionMode$Callback"
	.zero	85

	/* #140 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554541
	/* java_name */
	.ascii	"android/view/ActionProvider"
	.zero	90

	/* #141 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554557
	/* java_name */
	.ascii	"android/view/ContextMenu"
	.zero	93

	/* #142 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554555
	/* java_name */
	.ascii	"android/view/ContextMenu$ContextMenuInfo"
	.zero	77

	/* #143 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554543
	/* java_name */
	.ascii	"android/view/ContextThemeWrapper"
	.zero	85

	/* #144 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554544
	/* java_name */
	.ascii	"android/view/Display"
	.zero	97

	/* #145 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554545
	/* java_name */
	.ascii	"android/view/DragEvent"
	.zero	95

	/* #146 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554546
	/* java_name */
	.ascii	"android/view/GestureDetector"
	.zero	89

	/* #147 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554548
	/* java_name */
	.ascii	"android/view/GestureDetector$OnContextClickListener"
	.zero	66

	/* #148 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554550
	/* java_name */
	.ascii	"android/view/GestureDetector$OnDoubleTapListener"
	.zero	69

	/* #149 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554552
	/* java_name */
	.ascii	"android/view/GestureDetector$OnGestureListener"
	.zero	71

	/* #150 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554553
	/* java_name */
	.ascii	"android/view/GestureDetector$SimpleOnGestureListener"
	.zero	65

	/* #151 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554567
	/* java_name */
	.ascii	"android/view/InputEvent"
	.zero	94

	/* #152 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554578
	/* java_name */
	.ascii	"android/view/KeyEvent"
	.zero	96

	/* #153 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554580
	/* java_name */
	.ascii	"android/view/KeyEvent$Callback"
	.zero	87

	/* #154 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554581
	/* java_name */
	.ascii	"android/view/LayoutInflater"
	.zero	90

	/* #155 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554583
	/* java_name */
	.ascii	"android/view/LayoutInflater$Factory"
	.zero	82

	/* #156 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554585
	/* java_name */
	.ascii	"android/view/LayoutInflater$Factory2"
	.zero	81

	/* #157 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554587
	/* java_name */
	.ascii	"android/view/LayoutInflater$Filter"
	.zero	83

	/* #158 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554560
	/* java_name */
	.ascii	"android/view/Menu"
	.zero	100

	/* #159 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554589
	/* java_name */
	.ascii	"android/view/MenuInflater"
	.zero	92

	/* #160 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554566
	/* java_name */
	.ascii	"android/view/MenuItem"
	.zero	96

	/* #161 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554562
	/* java_name */
	.ascii	"android/view/MenuItem$OnActionExpandListener"
	.zero	73

	/* #162 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554564
	/* java_name */
	.ascii	"android/view/MenuItem$OnMenuItemClickListener"
	.zero	72

	/* #163 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554590
	/* java_name */
	.ascii	"android/view/MotionEvent"
	.zero	93

	/* #164 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554591
	/* java_name */
	.ascii	"android/view/SearchEvent"
	.zero	93

	/* #165 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554570
	/* java_name */
	.ascii	"android/view/SubMenu"
	.zero	97

	/* #166 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554592
	/* java_name */
	.ascii	"android/view/VelocityTracker"
	.zero	89

	/* #167 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554593
	/* java_name */
	.ascii	"android/view/View"
	.zero	100

	/* #168 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554594
	/* java_name */
	.ascii	"android/view/View$AccessibilityDelegate"
	.zero	78

	/* #169 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554596
	/* java_name */
	.ascii	"android/view/View$OnClickListener"
	.zero	84

	/* #170 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554599
	/* java_name */
	.ascii	"android/view/View$OnCreateContextMenuListener"
	.zero	72

	/* #171 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554601
	/* java_name */
	.ascii	"android/view/View$OnTouchListener"
	.zero	84

	/* #172 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554608
	/* java_name */
	.ascii	"android/view/ViewGroup"
	.zero	95

	/* #173 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554609
	/* java_name */
	.ascii	"android/view/ViewGroup$LayoutParams"
	.zero	82

	/* #174 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554610
	/* java_name */
	.ascii	"android/view/ViewGroup$MarginLayoutParams"
	.zero	76

	/* #175 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554572
	/* java_name */
	.ascii	"android/view/ViewManager"
	.zero	93

	/* #176 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554574
	/* java_name */
	.ascii	"android/view/ViewParent"
	.zero	94

	/* #177 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554612
	/* java_name */
	.ascii	"android/view/ViewPropertyAnimator"
	.zero	84

	/* #178 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554613
	/* java_name */
	.ascii	"android/view/ViewTreeObserver"
	.zero	88

	/* #179 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554615
	/* java_name */
	.ascii	"android/view/ViewTreeObserver$OnPreDrawListener"
	.zero	70

	/* #180 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554616
	/* java_name */
	.ascii	"android/view/Window"
	.zero	98

	/* #181 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554618
	/* java_name */
	.ascii	"android/view/Window$Callback"
	.zero	89

	/* #182 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554620
	/* java_name */
	.ascii	"android/view/WindowInsets"
	.zero	92

	/* #183 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554577
	/* java_name */
	.ascii	"android/view/WindowManager"
	.zero	91

	/* #184 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554575
	/* java_name */
	.ascii	"android/view/WindowManager$LayoutParams"
	.zero	78

	/* #185 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554647
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityEvent"
	.zero	72

	/* #186 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554651
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityEventSource"
	.zero	66

	/* #187 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554648
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityNodeInfo"
	.zero	69

	/* #188 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554649
	/* java_name */
	.ascii	"android/view/accessibility/AccessibilityRecord"
	.zero	71

	/* #189 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554640
	/* java_name */
	.ascii	"android/view/animation/Animation"
	.zero	85

	/* #190 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554642
	/* java_name */
	.ascii	"android/view/animation/BaseInterpolator"
	.zero	78

	/* #191 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554645
	/* java_name */
	.ascii	"android/view/animation/Interpolator"
	.zero	82

	/* #192 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554646
	/* java_name */
	.ascii	"android/view/animation/LinearInterpolator"
	.zero	76

	/* #193 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554636
	/* java_name */
	.ascii	"android/view/inputmethod/InputMethodManager"
	.zero	74

	/* #194 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554503
	/* java_name */
	.ascii	"android/widget/Adapter"
	.zero	95

	/* #195 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554487
	/* java_name */
	.ascii	"android/widget/AdapterView"
	.zero	91

	/* #196 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554489
	/* java_name */
	.ascii	"android/widget/AdapterView$OnItemSelectedListener"
	.zero	68

	/* #197 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554491
	/* java_name */
	.ascii	"android/widget/Button"
	.zero	96

	/* #198 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554492
	/* java_name */
	.ascii	"android/widget/CheckBox"
	.zero	94

	/* #199 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554505
	/* java_name */
	.ascii	"android/widget/Checkable"
	.zero	93

	/* #200 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554493
	/* java_name */
	.ascii	"android/widget/CompoundButton"
	.zero	88

	/* #201 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554495
	/* java_name */
	.ascii	"android/widget/DatePicker"
	.zero	92

	/* #202 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554497
	/* java_name */
	.ascii	"android/widget/DatePicker$OnDateChangedListener"
	.zero	70

	/* #203 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554498
	/* java_name */
	.ascii	"android/widget/EdgeEffect"
	.zero	92

	/* #204 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554499
	/* java_name */
	.ascii	"android/widget/EditText"
	.zero	94

	/* #205 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554500
	/* java_name */
	.ascii	"android/widget/FrameLayout"
	.zero	91

	/* #206 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554501
	/* java_name */
	.ascii	"android/widget/HorizontalScrollView"
	.zero	82

	/* #207 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554506
	/* java_name */
	.ascii	"android/widget/ImageButton"
	.zero	91

	/* #208 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554507
	/* java_name */
	.ascii	"android/widget/ImageView"
	.zero	93

	/* #209 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554510
	/* java_name */
	.ascii	"android/widget/LinearLayout"
	.zero	90

	/* #210 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554511
	/* java_name */
	.ascii	"android/widget/LinearLayout$LayoutParams"
	.zero	77

	/* #211 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554512
	/* java_name */
	.ascii	"android/widget/NumberPicker"
	.zero	90

	/* #212 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554513
	/* java_name */
	.ascii	"android/widget/ProgressBar"
	.zero	91

	/* #213 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554514
	/* java_name */
	.ascii	"android/widget/RadioButton"
	.zero	91

	/* #214 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554515
	/* java_name */
	.ascii	"android/widget/RelativeLayout"
	.zero	88

	/* #215 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554516
	/* java_name */
	.ascii	"android/widget/RelativeLayout$LayoutParams"
	.zero	75

	/* #216 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554517
	/* java_name */
	.ascii	"android/widget/RemoteViews"
	.zero	91

	/* #217 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554518
	/* java_name */
	.ascii	"android/widget/ScrollView"
	.zero	92

	/* #218 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554509
	/* java_name */
	.ascii	"android/widget/SpinnerAdapter"
	.zero	88

	/* #219 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554519
	/* java_name */
	.ascii	"android/widget/TableLayout"
	.zero	91

	/* #220 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554520
	/* java_name */
	.ascii	"android/widget/TableRow"
	.zero	94

	/* #221 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554521
	/* java_name */
	.ascii	"android/widget/TextView"
	.zero	94

	/* #222 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554522
	/* java_name */
	.ascii	"android/widget/TextView$BufferType"
	.zero	83

	/* #223 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554524
	/* java_name */
	.ascii	"android/widget/TextView$OnEditorActionListener"
	.zero	71

	/* #224 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554529
	/* java_name */
	.ascii	"android/widget/TimePicker"
	.zero	92

	/* #225 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554531
	/* java_name */
	.ascii	"android/widget/TimePicker$OnTimeChangedListener"
	.zero	70

	/* #226 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554532
	/* java_name */
	.ascii	"android/widget/Toast"
	.zero	97

	/* #227 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554533
	/* java_name */
	.ascii	"android/widget/Toolbar"
	.zero	95

	/* #228 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/activity/ComponentActivity"
	.zero	82

	/* #229 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"androidx/activity/OnBackPressedCallback"
	.zero	78

	/* #230 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"androidx/activity/OnBackPressedDispatcher"
	.zero	76

	/* #231 */
	/* module_index */
	.long	5
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/activity/OnBackPressedDispatcherOwner"
	.zero	71

	/* #232 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar"
	.zero	85

	/* #233 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$LayoutParams"
	.zero	72

	/* #234 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$OnMenuVisibilityListener"
	.zero	60

	/* #235 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554443
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$OnNavigationListener"
	.zero	64

	/* #236 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554444
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$Tab"
	.zero	81

	/* #237 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554447
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBar$TabListener"
	.zero	73

	/* #238 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554451
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBarDrawerToggle"
	.zero	73

	/* #239 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554453
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBarDrawerToggle$Delegate"
	.zero	64

	/* #240 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554455
	/* java_name */
	.ascii	"androidx/appcompat/app/ActionBarDrawerToggle$DelegateProvider"
	.zero	56

	/* #241 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554456
	/* java_name */
	.ascii	"androidx/appcompat/app/AppCompatActivity"
	.zero	77

	/* #242 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554460
	/* java_name */
	.ascii	"androidx/appcompat/app/AppCompatCallback"
	.zero	77

	/* #243 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554457
	/* java_name */
	.ascii	"androidx/appcompat/app/AppCompatDelegate"
	.zero	77

	/* #244 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/appcompat/graphics/drawable/DrawerArrowDrawable"
	.zero	61

	/* #245 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554476
	/* java_name */
	.ascii	"androidx/appcompat/view/ActionMode"
	.zero	83

	/* #246 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554478
	/* java_name */
	.ascii	"androidx/appcompat/view/ActionMode$Callback"
	.zero	74

	/* #247 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554480
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuBuilder"
	.zero	77

	/* #248 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554482
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuBuilder$Callback"
	.zero	68

	/* #249 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554489
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuItemImpl"
	.zero	76

	/* #250 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554486
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuPresenter"
	.zero	75

	/* #251 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554484
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuPresenter$Callback"
	.zero	66

	/* #252 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554488
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/MenuView"
	.zero	80

	/* #253 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554490
	/* java_name */
	.ascii	"androidx/appcompat/view/menu/SubMenuBuilder"
	.zero	74

	/* #254 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554470
	/* java_name */
	.ascii	"androidx/appcompat/widget/AppCompatEditText"
	.zero	74

	/* #255 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554471
	/* java_name */
	.ascii	"androidx/appcompat/widget/AppCompatTextView"
	.zero	74

	/* #256 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554473
	/* java_name */
	.ascii	"androidx/appcompat/widget/DecorToolbar"
	.zero	79

	/* #257 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554474
	/* java_name */
	.ascii	"androidx/appcompat/widget/ScrollingTabContainerView"
	.zero	66

	/* #258 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554475
	/* java_name */
	.ascii	"androidx/appcompat/widget/ScrollingTabContainerView$VisibilityAnimListener"
	.zero	43

	/* #259 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554461
	/* java_name */
	.ascii	"androidx/appcompat/widget/Toolbar"
	.zero	84

	/* #260 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554465
	/* java_name */
	.ascii	"androidx/appcompat/widget/Toolbar$OnMenuItemClickListener"
	.zero	60

	/* #261 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554462
	/* java_name */
	.ascii	"androidx/appcompat/widget/Toolbar_NavigationOnClickEventDispatcher"
	.zero	51

	/* #262 */
	/* module_index */
	.long	4
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/cardview/widget/CardView"
	.zero	84

	/* #263 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/coordinatorlayout/widget/CoordinatorLayout"
	.zero	66

	/* #264 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/coordinatorlayout/widget/CoordinatorLayout$Behavior"
	.zero	57

	/* #265 */
	/* module_index */
	.long	0
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"androidx/coordinatorlayout/widget/CoordinatorLayout$LayoutParams"
	.zero	53

	/* #266 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554511
	/* java_name */
	.ascii	"androidx/core/app/ActivityCompat"
	.zero	85

	/* #267 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554513
	/* java_name */
	.ascii	"androidx/core/app/ActivityCompat$OnRequestPermissionsResultCallback"
	.zero	50

	/* #268 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554515
	/* java_name */
	.ascii	"androidx/core/app/ActivityCompat$PermissionCompatDelegate"
	.zero	60

	/* #269 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554517
	/* java_name */
	.ascii	"androidx/core/app/ActivityCompat$RequestPermissionsRequestCodeValidator"
	.zero	46

	/* #270 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554518
	/* java_name */
	.ascii	"androidx/core/app/ComponentActivity"
	.zero	82

	/* #271 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554519
	/* java_name */
	.ascii	"androidx/core/app/ComponentActivity$ExtraData"
	.zero	72

	/* #272 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554521
	/* java_name */
	.ascii	"androidx/core/app/NotificationBuilderWithBuilderAccessor"
	.zero	61

	/* #273 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554522
	/* java_name */
	.ascii	"androidx/core/app/NotificationCompat"
	.zero	81

	/* #274 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554523
	/* java_name */
	.ascii	"androidx/core/app/NotificationCompat$Action"
	.zero	74

	/* #275 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554524
	/* java_name */
	.ascii	"androidx/core/app/NotificationCompat$BubbleMetadata"
	.zero	66

	/* #276 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554525
	/* java_name */
	.ascii	"androidx/core/app/NotificationCompat$Builder"
	.zero	73

	/* #277 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554527
	/* java_name */
	.ascii	"androidx/core/app/NotificationCompat$Extender"
	.zero	72

	/* #278 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554528
	/* java_name */
	.ascii	"androidx/core/app/NotificationCompat$Style"
	.zero	75

	/* #279 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554530
	/* java_name */
	.ascii	"androidx/core/app/RemoteInput"
	.zero	88

	/* #280 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554531
	/* java_name */
	.ascii	"androidx/core/app/SharedElementCallback"
	.zero	78

	/* #281 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554533
	/* java_name */
	.ascii	"androidx/core/app/SharedElementCallback$OnSharedElementsReadyListener"
	.zero	48

	/* #282 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554535
	/* java_name */
	.ascii	"androidx/core/app/TaskStackBuilder"
	.zero	83

	/* #283 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554537
	/* java_name */
	.ascii	"androidx/core/app/TaskStackBuilder$SupportParentable"
	.zero	65

	/* #284 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554509
	/* java_name */
	.ascii	"androidx/core/content/ContextCompat"
	.zero	82

	/* #285 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554510
	/* java_name */
	.ascii	"androidx/core/content/FileProvider"
	.zero	83

	/* #286 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554507
	/* java_name */
	.ascii	"androidx/core/graphics/Insets"
	.zero	88

	/* #287 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554508
	/* java_name */
	.ascii	"androidx/core/graphics/drawable/IconCompat"
	.zero	75

	/* #288 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554504
	/* java_name */
	.ascii	"androidx/core/internal/view/SupportMenu"
	.zero	78

	/* #289 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554506
	/* java_name */
	.ascii	"androidx/core/internal/view/SupportMenuItem"
	.zero	74

	/* #290 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554538
	/* java_name */
	.ascii	"androidx/core/text/PrecomputedTextCompat"
	.zero	77

	/* #291 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554539
	/* java_name */
	.ascii	"androidx/core/text/PrecomputedTextCompat$Params"
	.zero	70

	/* #292 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554449
	/* java_name */
	.ascii	"androidx/core/view/AccessibilityDelegateCompat"
	.zero	71

	/* #293 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554450
	/* java_name */
	.ascii	"androidx/core/view/ActionProvider"
	.zero	84

	/* #294 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554452
	/* java_name */
	.ascii	"androidx/core/view/ActionProvider$SubUiVisibilityListener"
	.zero	60

	/* #295 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554456
	/* java_name */
	.ascii	"androidx/core/view/ActionProvider$VisibilityListener"
	.zero	65

	/* #296 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554464
	/* java_name */
	.ascii	"androidx/core/view/DisplayCutoutCompat"
	.zero	79

	/* #297 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554465
	/* java_name */
	.ascii	"androidx/core/view/DragAndDropPermissionsCompat"
	.zero	70

	/* #298 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554486
	/* java_name */
	.ascii	"androidx/core/view/KeyEventDispatcher"
	.zero	80

	/* #299 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554488
	/* java_name */
	.ascii	"androidx/core/view/KeyEventDispatcher$Component"
	.zero	70

	/* #300 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554467
	/* java_name */
	.ascii	"androidx/core/view/NestedScrollingChild"
	.zero	78

	/* #301 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554469
	/* java_name */
	.ascii	"androidx/core/view/NestedScrollingChild2"
	.zero	77

	/* #302 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554471
	/* java_name */
	.ascii	"androidx/core/view/NestedScrollingChild3"
	.zero	77

	/* #303 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554473
	/* java_name */
	.ascii	"androidx/core/view/NestedScrollingParent"
	.zero	77

	/* #304 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554475
	/* java_name */
	.ascii	"androidx/core/view/NestedScrollingParent2"
	.zero	76

	/* #305 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554477
	/* java_name */
	.ascii	"androidx/core/view/NestedScrollingParent3"
	.zero	76

	/* #306 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554479
	/* java_name */
	.ascii	"androidx/core/view/ScrollingView"
	.zero	85

	/* #307 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554481
	/* java_name */
	.ascii	"androidx/core/view/TintableBackgroundView"
	.zero	76

	/* #308 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554489
	/* java_name */
	.ascii	"androidx/core/view/ViewPropertyAnimatorCompat"
	.zero	72

	/* #309 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554483
	/* java_name */
	.ascii	"androidx/core/view/ViewPropertyAnimatorListener"
	.zero	70

	/* #310 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554485
	/* java_name */
	.ascii	"androidx/core/view/ViewPropertyAnimatorUpdateListener"
	.zero	64

	/* #311 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554490
	/* java_name */
	.ascii	"androidx/core/view/WindowInsetsCompat"
	.zero	80

	/* #312 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554491
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityNodeInfoCompat"
	.zero	57

	/* #313 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554492
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat"
	.zero	31

	/* #314 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554493
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionInfoCompat"
	.zero	36

	/* #315 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554494
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionItemInfoCompat"
	.zero	32

	/* #316 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554495
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityNodeInfoCompat$RangeInfoCompat"
	.zero	41

	/* #317 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554496
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityNodeInfoCompat$TouchDelegateInfoCompat"
	.zero	33

	/* #318 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554497
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityNodeProviderCompat"
	.zero	53

	/* #319 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554502
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityViewCommand"
	.zero	60

	/* #320 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554499
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityViewCommand$CommandArguments"
	.zero	43

	/* #321 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554498
	/* java_name */
	.ascii	"androidx/core/view/accessibility/AccessibilityWindowInfoCompat"
	.zero	55

	/* #322 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/core/widget/AutoSizeableTextView"
	.zero	76

	/* #323 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554441
	/* java_name */
	.ascii	"androidx/core/widget/NestedScrollView"
	.zero	80

	/* #324 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554443
	/* java_name */
	.ascii	"androidx/core/widget/NestedScrollView$OnScrollChangeListener"
	.zero	57

	/* #325 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554448
	/* java_name */
	.ascii	"androidx/core/widget/TextViewCompat"
	.zero	82

	/* #326 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"androidx/core/widget/TintableCompoundDrawablesView"
	.zero	67

	/* #327 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"androidx/core/widget/TintableImageSourceView"
	.zero	73

	/* #328 */
	/* module_index */
	.long	10
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/drawerlayout/widget/DrawerLayout"
	.zero	76

	/* #329 */
	/* module_index */
	.long	10
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/drawerlayout/widget/DrawerLayout$DrawerListener"
	.zero	61

	/* #330 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/fragment/app/DialogFragment"
	.zero	81

	/* #331 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/fragment/app/Fragment"
	.zero	87

	/* #332 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"androidx/fragment/app/Fragment$SavedState"
	.zero	76

	/* #333 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentActivity"
	.zero	79

	/* #334 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentFactory"
	.zero	80

	/* #335 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentManager"
	.zero	80

	/* #336 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentManager$BackStackEntry"
	.zero	65

	/* #337 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554443
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentManager$FragmentLifecycleCallbacks"
	.zero	53

	/* #338 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554446
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentManager$OnBackStackChangedListener"
	.zero	53

	/* #339 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554451
	/* java_name */
	.ascii	"androidx/fragment/app/FragmentTransaction"
	.zero	76

	/* #340 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/lifecycle/Lifecycle"
	.zero	89

	/* #341 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/lifecycle/Lifecycle$State"
	.zero	83

	/* #342 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"androidx/lifecycle/LifecycleObserver"
	.zero	81

	/* #343 */
	/* module_index */
	.long	2
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"androidx/lifecycle/LifecycleOwner"
	.zero	84

	/* #344 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/lifecycle/LiveData"
	.zero	90

	/* #345 */
	/* module_index */
	.long	12
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/lifecycle/Observer"
	.zero	90

	/* #346 */
	/* module_index */
	.long	18
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/lifecycle/ViewModelStore"
	.zero	84

	/* #347 */
	/* module_index */
	.long	18
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/lifecycle/ViewModelStoreOwner"
	.zero	79

	/* #348 */
	/* module_index */
	.long	25
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"androidx/loader/app/LoaderManager"
	.zero	84

	/* #349 */
	/* module_index */
	.long	25
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"androidx/loader/app/LoaderManager$LoaderCallbacks"
	.zero	68

	/* #350 */
	/* module_index */
	.long	25
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/loader/content/Loader"
	.zero	87

	/* #351 */
	/* module_index */
	.long	25
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/loader/content/Loader$OnLoadCanceledListener"
	.zero	64

	/* #352 */
	/* module_index */
	.long	25
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"androidx/loader/content/Loader$OnLoadCompleteListener"
	.zero	64

	/* #353 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/recyclerview/widget/DefaultItemAnimator"
	.zero	69

	/* #354 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/recyclerview/widget/DiffUtil"
	.zero	80

	/* #355 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/recyclerview/widget/DiffUtil$Callback"
	.zero	71

	/* #356 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"androidx/recyclerview/widget/DiffUtil$DiffResult"
	.zero	69

	/* #357 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"androidx/recyclerview/widget/DividerItemDecoration"
	.zero	67

	/* #358 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554445
	/* java_name */
	.ascii	"androidx/recyclerview/widget/ItemTouchHelper"
	.zero	73

	/* #359 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554446
	/* java_name */
	.ascii	"androidx/recyclerview/widget/ItemTouchHelper$Callback"
	.zero	64

	/* #360 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554449
	/* java_name */
	.ascii	"androidx/recyclerview/widget/ItemTouchHelper$ViewDropHandler"
	.zero	57

	/* #361 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"androidx/recyclerview/widget/ItemTouchUIUtil"
	.zero	73

	/* #362 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554450
	/* java_name */
	.ascii	"androidx/recyclerview/widget/LinearLayoutManager"
	.zero	69

	/* #363 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554444
	/* java_name */
	.ascii	"androidx/recyclerview/widget/ListUpdateCallback"
	.zero	70

	/* #364 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554451
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView"
	.zero	76

	/* #365 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554452
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$Adapter"
	.zero	68

	/* #366 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554454
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$AdapterDataObserver"
	.zero	56

	/* #367 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554457
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$ChildDrawingOrderCallback"
	.zero	50

	/* #368 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554458
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$EdgeEffectFactory"
	.zero	58

	/* #369 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554459
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$ItemAnimator"
	.zero	63

	/* #370 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554461
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemAnimatorFinishedListener"
	.zero	34

	/* #371 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554462
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo"
	.zero	48

	/* #372 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554464
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$ItemDecoration"
	.zero	61

	/* #373 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554466
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$LayoutManager"
	.zero	62

	/* #374 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554468
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$LayoutManager$LayoutPrefetchRegistry"
	.zero	39

	/* #375 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554469
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$LayoutManager$Properties"
	.zero	51

	/* #376 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554471
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$LayoutParams"
	.zero	63

	/* #377 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554473
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$OnChildAttachStateChangeListener"
	.zero	43

	/* #378 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554477
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$OnFlingListener"
	.zero	60

	/* #379 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554480
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$OnItemTouchListener"
	.zero	56

	/* #380 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554485
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$OnScrollListener"
	.zero	59

	/* #381 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554487
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$RecycledViewPool"
	.zero	59

	/* #382 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554488
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$Recycler"
	.zero	67

	/* #383 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554490
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$RecyclerListener"
	.zero	59

	/* #384 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554493
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$SmoothScroller"
	.zero	61

	/* #385 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554494
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$SmoothScroller$Action"
	.zero	54

	/* #386 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554496
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$SmoothScroller$ScrollVectorProvider"
	.zero	40

	/* #387 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554498
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$State"
	.zero	70

	/* #388 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554499
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$ViewCacheExtension"
	.zero	57

	/* #389 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554501
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerView$ViewHolder"
	.zero	65

	/* #390 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554515
	/* java_name */
	.ascii	"androidx/recyclerview/widget/RecyclerViewAccessibilityDelegate"
	.zero	55

	/* #391 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554516
	/* java_name */
	.ascii	"androidx/recyclerview/widget/SimpleItemAnimator"
	.zero	70

	/* #392 */
	/* module_index */
	.long	14
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"androidx/savedstate/SavedStateRegistry"
	.zero	79

	/* #393 */
	/* module_index */
	.long	14
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"androidx/savedstate/SavedStateRegistry$SavedStateProvider"
	.zero	60

	/* #394 */
	/* module_index */
	.long	14
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"androidx/savedstate/SavedStateRegistryOwner"
	.zero	74

	/* #395 */
	/* module_index */
	.long	11
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"androidx/versionedparcelable/CustomVersionedParcelable"
	.zero	63

	/* #396 */
	/* module_index */
	.long	11
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"androidx/versionedparcelable/VersionedParcelable"
	.zero	69

	/* #397 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"com/github/mikephil/charting/BuildConfig"
	.zero	77

	/* #398 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554644
	/* java_name */
	.ascii	"com/github/mikephil/charting/animation/ChartAnimator"
	.zero	65

	/* #399 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554645
	/* java_name */
	.ascii	"com/github/mikephil/charting/animation/Easing"
	.zero	72

	/* #400 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554647
	/* java_name */
	.ascii	"com/github/mikephil/charting/animation/Easing$EasingFunction"
	.zero	57

	/* #401 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554648
	/* java_name */
	.ascii	"com/github/mikephil/charting/animation/Easing$EasingOption"
	.zero	59

	/* #402 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554665
	/* java_name */
	.ascii	"com/github/mikephil/charting/buffer/AbstractBuffer"
	.zero	67

	/* #403 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554664
	/* java_name */
	.ascii	"com/github/mikephil/charting/buffer/BarBuffer"
	.zero	72

	/* #404 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554667
	/* java_name */
	.ascii	"com/github/mikephil/charting/buffer/HorizontalBarBuffer"
	.zero	62

	/* #405 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554627
	/* java_name */
	.ascii	"com/github/mikephil/charting/charts/BarChart"
	.zero	73

	/* #406 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554628
	/* java_name */
	.ascii	"com/github/mikephil/charting/charts/BarLineChartBase"
	.zero	65

	/* #407 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554630
	/* java_name */
	.ascii	"com/github/mikephil/charting/charts/BubbleChart"
	.zero	70

	/* #408 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554631
	/* java_name */
	.ascii	"com/github/mikephil/charting/charts/CandleStickChart"
	.zero	65

	/* #409 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554632
	/* java_name */
	.ascii	"com/github/mikephil/charting/charts/Chart"
	.zero	76

	/* #410 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554634
	/* java_name */
	.ascii	"com/github/mikephil/charting/charts/CombinedChart"
	.zero	68

	/* #411 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554635
	/* java_name */
	.ascii	"com/github/mikephil/charting/charts/CombinedChart$DrawOrder"
	.zero	58

	/* #412 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554636
	/* java_name */
	.ascii	"com/github/mikephil/charting/charts/HorizontalBarChart"
	.zero	63

	/* #413 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554637
	/* java_name */
	.ascii	"com/github/mikephil/charting/charts/LineChart"
	.zero	72

	/* #414 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554638
	/* java_name */
	.ascii	"com/github/mikephil/charting/charts/PieChart"
	.zero	73

	/* #415 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554639
	/* java_name */
	.ascii	"com/github/mikephil/charting/charts/PieRadarChartBase"
	.zero	64

	/* #416 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554641
	/* java_name */
	.ascii	"com/github/mikephil/charting/charts/RadarChart"
	.zero	71

	/* #417 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554642
	/* java_name */
	.ascii	"com/github/mikephil/charting/charts/ScatterChart"
	.zero	69

	/* #418 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554643
	/* java_name */
	.ascii	"com/github/mikephil/charting/charts/ScatterChart$ScatterShape"
	.zero	56

	/* #419 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554603
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/AxisBase"
	.zero	69

	/* #420 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554605
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/ComponentBase"
	.zero	64

	/* #421 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554607
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/Description"
	.zero	66

	/* #422 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554609
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/IMarker"
	.zero	70

	/* #423 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554610
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/Legend"
	.zero	71

	/* #424 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554611
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/Legend$LegendDirection"
	.zero	55

	/* #425 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554612
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/Legend$LegendForm"
	.zero	60

	/* #426 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554613
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/Legend$LegendHorizontalAlignment"
	.zero	45

	/* #427 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554614
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/Legend$LegendOrientation"
	.zero	53

	/* #428 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554615
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/Legend$LegendPosition"
	.zero	56

	/* #429 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554616
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/Legend$LegendVerticalAlignment"
	.zero	47

	/* #430 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554617
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/LegendEntry"
	.zero	66

	/* #431 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554618
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/LimitLine"
	.zero	68

	/* #432 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554619
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/LimitLine$LimitLabelPosition"
	.zero	49

	/* #433 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554620
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/MarkerImage"
	.zero	66

	/* #434 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554621
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/MarkerView"
	.zero	67

	/* #435 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554622
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/XAxis"
	.zero	72

	/* #436 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554623
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/XAxis$XAxisPosition"
	.zero	58

	/* #437 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554624
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/YAxis"
	.zero	72

	/* #438 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554625
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/YAxis$AxisDependency"
	.zero	57

	/* #439 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554626
	/* java_name */
	.ascii	"com/github/mikephil/charting/components/YAxis$YAxisLabelPosition"
	.zero	53

	/* #440 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554562
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/BarData"
	.zero	76

	/* #441 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554563
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/BarDataSet"
	.zero	73

	/* #442 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554564
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/BarEntry"
	.zero	75

	/* #443 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554565
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/BarLineScatterCandleBubbleData"
	.zero	53

	/* #444 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554567
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/BarLineScatterCandleBubbleDataSet"
	.zero	50

	/* #445 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554569
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/BaseDataSet"
	.zero	72

	/* #446 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554571
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/BaseEntry"
	.zero	74

	/* #447 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554573
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/BubbleData"
	.zero	73

	/* #448 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554574
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/BubbleDataSet"
	.zero	70

	/* #449 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554575
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/BubbleEntry"
	.zero	72

	/* #450 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554576
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/CandleData"
	.zero	73

	/* #451 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554577
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/CandleDataSet"
	.zero	70

	/* #452 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554578
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/CandleEntry"
	.zero	72

	/* #453 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554579
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/ChartData"
	.zero	74

	/* #454 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554581
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/CombinedData"
	.zero	71

	/* #455 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554582
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/DataSet"
	.zero	76

	/* #456 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554583
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/DataSet$Rounding"
	.zero	67

	/* #457 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554585
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/Entry"
	.zero	78

	/* #458 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554586
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/LineData"
	.zero	75

	/* #459 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554587
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/LineDataSet"
	.zero	72

	/* #460 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554588
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/LineDataSet$Mode"
	.zero	67

	/* #461 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554589
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/LineRadarDataSet"
	.zero	67

	/* #462 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554591
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/LineScatterCandleRadarDataSet"
	.zero	54

	/* #463 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554593
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/PieData"
	.zero	76

	/* #464 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554594
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/PieDataSet"
	.zero	73

	/* #465 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554595
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/PieDataSet$ValuePosition"
	.zero	59

	/* #466 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554596
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/PieEntry"
	.zero	75

	/* #467 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554597
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/RadarData"
	.zero	74

	/* #468 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554598
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/RadarDataSet"
	.zero	71

	/* #469 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554599
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/RadarEntry"
	.zero	73

	/* #470 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554600
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/ScatterData"
	.zero	72

	/* #471 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554601
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/ScatterDataSet"
	.zero	69

	/* #472 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554602
	/* java_name */
	.ascii	"com/github/mikephil/charting/data/filter/Approximator"
	.zero	64

	/* #473 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554561
	/* java_name */
	.ascii	"com/github/mikephil/charting/exception/DrawingDataSetNotCreatedException"
	.zero	45

	/* #474 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554552
	/* java_name */
	.ascii	"com/github/mikephil/charting/formatter/ColorFormatter"
	.zero	64

	/* #475 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554546
	/* java_name */
	.ascii	"com/github/mikephil/charting/formatter/DefaultAxisValueFormatter"
	.zero	53

	/* #476 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554547
	/* java_name */
	.ascii	"com/github/mikephil/charting/formatter/DefaultFillFormatter"
	.zero	58

	/* #477 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554548
	/* java_name */
	.ascii	"com/github/mikephil/charting/formatter/DefaultValueFormatter"
	.zero	57

	/* #478 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554550
	/* java_name */
	.ascii	"com/github/mikephil/charting/formatter/IAxisValueFormatter"
	.zero	59

	/* #479 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554554
	/* java_name */
	.ascii	"com/github/mikephil/charting/formatter/IFillFormatter"
	.zero	64

	/* #480 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554557
	/* java_name */
	.ascii	"com/github/mikephil/charting/formatter/IValueFormatter"
	.zero	63

	/* #481 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554555
	/* java_name */
	.ascii	"com/github/mikephil/charting/formatter/IndexAxisValueFormatter"
	.zero	55

	/* #482 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554558
	/* java_name */
	.ascii	"com/github/mikephil/charting/formatter/LargeValueFormatter"
	.zero	59

	/* #483 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554559
	/* java_name */
	.ascii	"com/github/mikephil/charting/formatter/PercentFormatter"
	.zero	62

	/* #484 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554560
	/* java_name */
	.ascii	"com/github/mikephil/charting/formatter/StackedValueFormatter"
	.zero	57

	/* #485 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554534
	/* java_name */
	.ascii	"com/github/mikephil/charting/highlight/BarHighlighter"
	.zero	64

	/* #486 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554535
	/* java_name */
	.ascii	"com/github/mikephil/charting/highlight/ChartHighlighter"
	.zero	62

	/* #487 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554536
	/* java_name */
	.ascii	"com/github/mikephil/charting/highlight/CombinedHighlighter"
	.zero	59

	/* #488 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554537
	/* java_name */
	.ascii	"com/github/mikephil/charting/highlight/Highlight"
	.zero	69

	/* #489 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554538
	/* java_name */
	.ascii	"com/github/mikephil/charting/highlight/HorizontalBarHighlighter"
	.zero	54

	/* #490 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554540
	/* java_name */
	.ascii	"com/github/mikephil/charting/highlight/IHighlighter"
	.zero	66

	/* #491 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554541
	/* java_name */
	.ascii	"com/github/mikephil/charting/highlight/PieHighlighter"
	.zero	64

	/* #492 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554542
	/* java_name */
	.ascii	"com/github/mikephil/charting/highlight/PieRadarHighlighter"
	.zero	59

	/* #493 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554544
	/* java_name */
	.ascii	"com/github/mikephil/charting/highlight/RadarHighlighter"
	.zero	62

	/* #494 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554545
	/* java_name */
	.ascii	"com/github/mikephil/charting/highlight/Range"
	.zero	73

	/* #495 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554519
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/dataprovider/BarDataProvider"
	.zero	49

	/* #496 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554521
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/dataprovider/BarLineScatterCandleBubbleDataProvider"
	.zero	26

	/* #497 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554523
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/dataprovider/BubbleDataProvider"
	.zero	46

	/* #498 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554525
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/dataprovider/CandleDataProvider"
	.zero	46

	/* #499 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554527
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/dataprovider/ChartInterface"
	.zero	50

	/* #500 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554529
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/dataprovider/CombinedDataProvider"
	.zero	44

	/* #501 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554531
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/dataprovider/LineDataProvider"
	.zero	48

	/* #502 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554533
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/dataprovider/ScatterDataProvider"
	.zero	45

	/* #503 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554497
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/datasets/IBarDataSet"
	.zero	57

	/* #504 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554499
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/datasets/IBarLineScatterCandleBubbleDataSet"
	.zero	34

	/* #505 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554501
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/datasets/IBubbleDataSet"
	.zero	54

	/* #506 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554503
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/datasets/ICandleDataSet"
	.zero	54

	/* #507 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554505
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/datasets/IDataSet"
	.zero	60

	/* #508 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554507
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/datasets/ILineDataSet"
	.zero	56

	/* #509 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554509
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/datasets/ILineRadarDataSet"
	.zero	51

	/* #510 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554511
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/datasets/ILineScatterCandleRadarDataSet"
	.zero	38

	/* #511 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554513
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/datasets/IPieDataSet"
	.zero	57

	/* #512 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554515
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/datasets/IRadarDataSet"
	.zero	55

	/* #513 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554517
	/* java_name */
	.ascii	"com/github/mikephil/charting/interfaces/datasets/IScatterDataSet"
	.zero	53

	/* #514 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554488
	/* java_name */
	.ascii	"com/github/mikephil/charting/jobs/AnimatedMoveViewJob"
	.zero	64

	/* #515 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554489
	/* java_name */
	.ascii	"com/github/mikephil/charting/jobs/AnimatedViewPortJob"
	.zero	64

	/* #516 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554491
	/* java_name */
	.ascii	"com/github/mikephil/charting/jobs/AnimatedZoomJob"
	.zero	68

	/* #517 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554492
	/* java_name */
	.ascii	"com/github/mikephil/charting/jobs/MoveViewJob"
	.zero	72

	/* #518 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554493
	/* java_name */
	.ascii	"com/github/mikephil/charting/jobs/ViewPortJob"
	.zero	72

	/* #519 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554495
	/* java_name */
	.ascii	"com/github/mikephil/charting/jobs/ZoomJob"
	.zero	76

	/* #520 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554476
	/* java_name */
	.ascii	"com/github/mikephil/charting/listener/BarLineChartTouchListener"
	.zero	54

	/* #521 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554477
	/* java_name */
	.ascii	"com/github/mikephil/charting/listener/ChartTouchListener"
	.zero	61

	/* #522 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554478
	/* java_name */
	.ascii	"com/github/mikephil/charting/listener/ChartTouchListener$ChartGesture"
	.zero	48

	/* #523 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554481
	/* java_name */
	.ascii	"com/github/mikephil/charting/listener/OnChartGestureListener"
	.zero	57

	/* #524 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554483
	/* java_name */
	.ascii	"com/github/mikephil/charting/listener/OnChartValueSelectedListener"
	.zero	51

	/* #525 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554486
	/* java_name */
	.ascii	"com/github/mikephil/charting/listener/OnDrawLineChartTouchListener"
	.zero	51

	/* #526 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554485
	/* java_name */
	.ascii	"com/github/mikephil/charting/listener/OnDrawListener"
	.zero	65

	/* #527 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554487
	/* java_name */
	.ascii	"com/github/mikephil/charting/listener/PieRadarChartTouchListener"
	.zero	53

	/* #528 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554475
	/* java_name */
	.ascii	"com/github/mikephil/charting/matrix/Vector3"
	.zero	74

	/* #529 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554474
	/* java_name */
	.ascii	"com/github/mikephil/charting/model/GradientColor"
	.zero	69

	/* #530 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/AxisRenderer"
	.zero	67

	/* #531 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/BarChartRenderer"
	.zero	63

	/* #532 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer"
	.zero	45

	/* #533 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer$XBounds"
	.zero	37

	/* #534 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/BubbleChartRenderer"
	.zero	60

	/* #535 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554443
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/CandleStickChartRenderer"
	.zero	55

	/* #536 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554444
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/CombinedChartRenderer"
	.zero	58

	/* #537 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554445
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/DataRenderer"
	.zero	67

	/* #538 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554447
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/HorizontalBarChartRenderer"
	.zero	53

	/* #539 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554448
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/LegendRenderer"
	.zero	65

	/* #540 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554449
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/LineChartRenderer"
	.zero	62

	/* #541 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554450
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/LineRadarRenderer"
	.zero	62

	/* #542 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554452
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/LineScatterCandleRadarRenderer"
	.zero	49

	/* #543 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554454
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/PieChartRenderer"
	.zero	63

	/* #544 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554455
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/RadarChartRenderer"
	.zero	61

	/* #545 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554456
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/Renderer"
	.zero	71

	/* #546 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554458
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/ScatterChartRenderer"
	.zero	59

	/* #547 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554459
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/XAxisRenderer"
	.zero	66

	/* #548 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554460
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/XAxisRendererHorizontalBarChart"
	.zero	48

	/* #549 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554461
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/XAxisRendererRadarChart"
	.zero	56

	/* #550 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554462
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/YAxisRenderer"
	.zero	66

	/* #551 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554463
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/YAxisRendererHorizontalBarChart"
	.zero	48

	/* #552 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554464
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/YAxisRendererRadarChart"
	.zero	56

	/* #553 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554465
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/scatter/ChevronDownShapeRenderer"
	.zero	47

	/* #554 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554466
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/scatter/ChevronUpShapeRenderer"
	.zero	49

	/* #555 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554467
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/scatter/CircleShapeRenderer"
	.zero	52

	/* #556 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554468
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/scatter/CrossShapeRenderer"
	.zero	53

	/* #557 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554470
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/scatter/IShapeRenderer"
	.zero	57

	/* #558 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554471
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/scatter/SquareShapeRenderer"
	.zero	52

	/* #559 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554472
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/scatter/TriangleShapeRenderer"
	.zero	50

	/* #560 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554473
	/* java_name */
	.ascii	"com/github/mikephil/charting/renderer/scatter/XShapeRenderer"
	.zero	57

	/* #561 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554650
	/* java_name */
	.ascii	"com/github/mikephil/charting/utils/ColorTemplate"
	.zero	69

	/* #562 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554649
	/* java_name */
	.ascii	"com/github/mikephil/charting/utils/EntryXComparator"
	.zero	66

	/* #563 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554652
	/* java_name */
	.ascii	"com/github/mikephil/charting/utils/FSize"
	.zero	77

	/* #564 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554651
	/* java_name */
	.ascii	"com/github/mikephil/charting/utils/FileUtils"
	.zero	73

	/* #565 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554653
	/* java_name */
	.ascii	"com/github/mikephil/charting/utils/HorizontalViewPortHandler"
	.zero	57

	/* #566 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554654
	/* java_name */
	.ascii	"com/github/mikephil/charting/utils/MPPointD"
	.zero	74

	/* #567 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554655
	/* java_name */
	.ascii	"com/github/mikephil/charting/utils/MPPointF"
	.zero	74

	/* #568 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554656
	/* java_name */
	.ascii	"com/github/mikephil/charting/utils/ObjectPool"
	.zero	72

	/* #569 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554657
	/* java_name */
	.ascii	"com/github/mikephil/charting/utils/ObjectPool$Poolable"
	.zero	63

	/* #570 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554659
	/* java_name */
	.ascii	"com/github/mikephil/charting/utils/Transformer"
	.zero	71

	/* #571 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554660
	/* java_name */
	.ascii	"com/github/mikephil/charting/utils/TransformerHorizontalBarChart"
	.zero	53

	/* #572 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554661
	/* java_name */
	.ascii	"com/github/mikephil/charting/utils/Utils"
	.zero	77

	/* #573 */
	/* module_index */
	.long	22
	/* type_token_id */
	.long	33554663
	/* java_name */
	.ascii	"com/github/mikephil/charting/utils/ViewPortHandler"
	.zero	67

	/* #574 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554437
	/* java_name */
	.ascii	"com/google/android/gms/tasks/CancellationToken"
	.zero	71

	/* #575 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554440
	/* java_name */
	.ascii	"com/google/android/gms/tasks/Continuation"
	.zero	76

	/* #576 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"com/google/android/gms/tasks/OnCanceledListener"
	.zero	70

	/* #577 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554444
	/* java_name */
	.ascii	"com/google/android/gms/tasks/OnCompleteListener"
	.zero	70

	/* #578 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554446
	/* java_name */
	.ascii	"com/google/android/gms/tasks/OnFailureListener"
	.zero	71

	/* #579 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554448
	/* java_name */
	.ascii	"com/google/android/gms/tasks/OnSuccessListener"
	.zero	71

	/* #580 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554450
	/* java_name */
	.ascii	"com/google/android/gms/tasks/OnTokenCanceledListener"
	.zero	65

	/* #581 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554452
	/* java_name */
	.ascii	"com/google/android/gms/tasks/SuccessContinuation"
	.zero	69

	/* #582 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"com/google/android/gms/tasks/Task"
	.zero	84

	/* #583 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"com/google/android/gms/tasks/TaskCompletionSource"
	.zero	68

	/* #584 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554473
	/* java_name */
	.ascii	"com/google/android/material/animation/MotionSpec"
	.zero	69

	/* #585 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554474
	/* java_name */
	.ascii	"com/google/android/material/animation/MotionTiming"
	.zero	67

	/* #586 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"com/google/android/material/behavior/SwipeDismissBehavior"
	.zero	60

	/* #587 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554444
	/* java_name */
	.ascii	"com/google/android/material/behavior/SwipeDismissBehavior$OnDismissListener"
	.zero	42

	/* #588 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554460
	/* java_name */
	.ascii	"com/google/android/material/bottomnavigation/BottomNavigationView"
	.zero	52

	/* #589 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554462
	/* java_name */
	.ascii	"com/google/android/material/bottomnavigation/BottomNavigationView$OnNavigationItemReselectedListener"
	.zero	17

	/* #590 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554466
	/* java_name */
	.ascii	"com/google/android/material/bottomnavigation/BottomNavigationView$OnNavigationItemSelectedListener"
	.zero	19

	/* #591 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"com/google/android/material/expandable/ExpandableTransformationWidget"
	.zero	48

	/* #592 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554441
	/* java_name */
	.ascii	"com/google/android/material/expandable/ExpandableWidget"
	.zero	62

	/* #593 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"com/google/android/material/floatingactionbutton/FloatingActionButton"
	.zero	48

	/* #594 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"com/google/android/material/floatingactionbutton/FloatingActionButton$OnVisibilityChangedListener"
	.zero	20

	/* #595 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554459
	/* java_name */
	.ascii	"com/google/android/material/internal/VisibilityAwareImageButton"
	.zero	54

	/* #596 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554452
	/* java_name */
	.ascii	"com/google/android/material/snackbar/BaseTransientBottomBar"
	.zero	58

	/* #597 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554453
	/* java_name */
	.ascii	"com/google/android/material/snackbar/BaseTransientBottomBar$BaseCallback"
	.zero	45

	/* #598 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554455
	/* java_name */
	.ascii	"com/google/android/material/snackbar/BaseTransientBottomBar$Behavior"
	.zero	49

	/* #599 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554458
	/* java_name */
	.ascii	"com/google/android/material/snackbar/ContentViewCallback"
	.zero	61

	/* #600 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554449
	/* java_name */
	.ascii	"com/google/android/material/snackbar/Snackbar"
	.zero	72

	/* #601 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554451
	/* java_name */
	.ascii	"com/google/android/material/snackbar/Snackbar$Callback"
	.zero	63

	/* #602 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554450
	/* java_name */
	.ascii	"com/google/android/material/snackbar/Snackbar_SnackbarActionClickImplementor"
	.zero	41

	/* #603 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554448
	/* java_name */
	.ascii	"com/google/android/material/textfield/TextInputEditText"
	.zero	62

	/* #604 */
	/* module_index */
	.long	19
	/* type_token_id */
	.long	33554439
	/* java_name */
	.ascii	"com/google/auto/value/AutoAnnotation"
	.zero	81

	/* #605 */
	/* module_index */
	.long	19
	/* type_token_id */
	.long	33554441
	/* java_name */
	.ascii	"com/google/auto/value/AutoOneOf"
	.zero	86

	/* #606 */
	/* module_index */
	.long	19
	/* type_token_id */
	.long	33554447
	/* java_name */
	.ascii	"com/google/auto/value/AutoValue"
	.zero	86

	/* #607 */
	/* module_index */
	.long	19
	/* type_token_id */
	.long	33554443
	/* java_name */
	.ascii	"com/google/auto/value/AutoValue$Builder"
	.zero	78

	/* #608 */
	/* module_index */
	.long	19
	/* type_token_id */
	.long	33554445
	/* java_name */
	.ascii	"com/google/auto/value/AutoValue$CopyAnnotations"
	.zero	70

	/* #609 */
	/* module_index */
	.long	19
	/* type_token_id */
	.long	33554449
	/* java_name */
	.ascii	"com/google/auto/value/extension/memoized/Memoized"
	.zero	68

	/* #610 */
	/* module_index */
	.long	23
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"com/google/common/util/concurrent/ListenableFuture"
	.zero	67

	/* #611 */
	/* module_index */
	.long	20
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"com/google/firebase/analytics/FirebaseAnalytics"
	.zero	70

	/* #612 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554606
	/* java_name */
	.ascii	"crc64011f11f03f56d783/MainActivity"
	.zero	83

	/* #613 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554562
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/BlackoutFragment"
	.zero	79

	/* #614 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554552
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/BlackoutSetupFragment"
	.zero	74

	/* #615 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554569
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/DonationDialogFragment"
	.zero	73

	/* #616 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554558
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/FeedbackFragment"
	.zero	79

	/* #617 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554596
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/FirstTimeSetupFragment"
	.zero	73

	/* #618 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554589
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/HomeFragment"
	.zero	83

	/* #619 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554548
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/OpenSourceDialogFragment"
	.zero	71

	/* #620 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554581
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/ScheduleFragment"
	.zero	79

	/* #621 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554571
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/SettingsFragment"
	.zero	79

	/* #622 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554597
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/StatisticsFragment"
	.zero	77

	/* #623 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554599
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/StatisticsFragment_IntFormatter"
	.zero	64

	/* #624 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554600
	/* java_name */
	.ascii	"crc640722b965c6d4e9e0/StatisticsFragment_MoneyFormatter"
	.zero	62

	/* #625 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554454
	/* java_name */
	.ascii	"crc6439c91b2afff7152e/CurvedBottomNavigationView"
	.zero	69

	/* #626 */
	/* module_index */
	.long	1
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"crc64435a5ac349fa9fda/ActivityLifecycleContextListener"
	.zero	63

	/* #627 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"crc64603d44a7cc04861c/MainApplication"
	.zero	80

	/* #628 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554461
	/* java_name */
	.ascii	"crc648f9c7c37abc5d059/BootMessageReceiver"
	.zero	76

	/* #629 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554462
	/* java_name */
	.ascii	"crc648f9c7c37abc5d059/GenericBroadcastReceiver"
	.zero	71

	/* #630 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554455
	/* java_name */
	.ascii	"crc64940f4e21f98af2d5/EnforcerService"
	.zero	80

	/* #631 */
	/* module_index */
	.long	7
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"crc6495d4f5d63cc5c882/AwaitableTaskCompleteListener_1"
	.zero	64

	/* #632 */
	/* module_index */
	.long	13
	/* type_token_id */
	.long	33554459
	/* java_name */
	.ascii	"crc64a0e0a82d0db9a07d/ActivityLifecycleContextListener"
	.zero	63

	/* #633 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554472
	/* java_name */
	.ascii	"crc64acecdea9d5776d16/UIApplicationDiffCallback"
	.zero	70

	/* #634 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554471
	/* java_name */
	.ascii	"crc64acecdea9d5776d16/UIApplicationListAdapter"
	.zero	71

	/* #635 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554469
	/* java_name */
	.ascii	"crc64acecdea9d5776d16/UIApplicationListHolder"
	.zero	72

	/* #636 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554476
	/* java_name */
	.ascii	"crc64acecdea9d5776d16/UIBlackoutListAdapter"
	.zero	74

	/* #637 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554474
	/* java_name */
	.ascii	"crc64acecdea9d5776d16/UIBlackoutListHolder"
	.zero	75

	/* #638 */
	/* module_index */
	.long	16
	/* type_token_id */
	.long	33554438
	/* java_name */
	.ascii	"crc64b5a97285ca981d80/InAppBillingImplementation_InAppBillingServiceConnection"
	.zero	39

	/* #639 */
	/* module_index */
	.long	21
	/* type_token_id */
	.long	33554435
	/* java_name */
	.ascii	"crc64bffe522d9943944b/IInAppBillingServiceStub"
	.zero	71

	/* #640 */
	/* module_index */
	.long	21
	/* type_token_id */
	.long	33554436
	/* java_name */
	.ascii	"crc64bffe522d9943944b/IInAppBillingServiceStub_Proxy"
	.zero	65

	/* #641 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554602
	/* java_name */
	.ascii	"crc64d871208f730dc43d/DatePickerDialogFragment"
	.zero	71

	/* #642 */
	/* module_index */
	.long	8
	/* type_token_id */
	.long	33554604
	/* java_name */
	.ascii	"crc64d871208f730dc43d/TimePickerDialogFragment"
	.zero	71

	/* #643 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555120
	/* java_name */
	.ascii	"java/io/Closeable"
	.zero	100

	/* #644 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555116
	/* java_name */
	.ascii	"java/io/File"
	.zero	105

	/* #645 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555117
	/* java_name */
	.ascii	"java/io/FileDescriptor"
	.zero	95

	/* #646 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555118
	/* java_name */
	.ascii	"java/io/FileInputStream"
	.zero	94

	/* #647 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555122
	/* java_name */
	.ascii	"java/io/Flushable"
	.zero	100

	/* #648 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555125
	/* java_name */
	.ascii	"java/io/IOException"
	.zero	98

	/* #649 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555123
	/* java_name */
	.ascii	"java/io/InputStream"
	.zero	98

	/* #650 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555128
	/* java_name */
	.ascii	"java/io/OutputStream"
	.zero	97

	/* #651 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555130
	/* java_name */
	.ascii	"java/io/PrintWriter"
	.zero	98

	/* #652 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555127
	/* java_name */
	.ascii	"java/io/Serializable"
	.zero	97

	/* #653 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555131
	/* java_name */
	.ascii	"java/io/StringWriter"
	.zero	97

	/* #654 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555132
	/* java_name */
	.ascii	"java/io/Writer"
	.zero	103

	/* #655 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555069
	/* java_name */
	.ascii	"java/lang/Appendable"
	.zero	97

	/* #656 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555071
	/* java_name */
	.ascii	"java/lang/AutoCloseable"
	.zero	94

	/* #657 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555054
	/* java_name */
	.ascii	"java/lang/Boolean"
	.zero	100

	/* #658 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555055
	/* java_name */
	.ascii	"java/lang/Byte"
	.zero	103

	/* #659 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555073
	/* java_name */
	.ascii	"java/lang/CharSequence"
	.zero	95

	/* #660 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555056
	/* java_name */
	.ascii	"java/lang/Character"
	.zero	98

	/* #661 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555057
	/* java_name */
	.ascii	"java/lang/Class"
	.zero	102

	/* #662 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555058
	/* java_name */
	.ascii	"java/lang/ClassCastException"
	.zero	89

	/* #663 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555059
	/* java_name */
	.ascii	"java/lang/ClassLoader"
	.zero	96

	/* #664 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555061
	/* java_name */
	.ascii	"java/lang/ClassNotFoundException"
	.zero	85

	/* #665 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555076
	/* java_name */
	.ascii	"java/lang/Cloneable"
	.zero	98

	/* #666 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555078
	/* java_name */
	.ascii	"java/lang/Comparable"
	.zero	97

	/* #667 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555062
	/* java_name */
	.ascii	"java/lang/Double"
	.zero	101

	/* #668 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555063
	/* java_name */
	.ascii	"java/lang/Enum"
	.zero	103

	/* #669 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555065
	/* java_name */
	.ascii	"java/lang/Error"
	.zero	102

	/* #670 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555066
	/* java_name */
	.ascii	"java/lang/Exception"
	.zero	98

	/* #671 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555067
	/* java_name */
	.ascii	"java/lang/Float"
	.zero	102

	/* #672 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555081
	/* java_name */
	.ascii	"java/lang/IllegalArgumentException"
	.zero	83

	/* #673 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555082
	/* java_name */
	.ascii	"java/lang/IllegalStateException"
	.zero	86

	/* #674 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555083
	/* java_name */
	.ascii	"java/lang/IndexOutOfBoundsException"
	.zero	82

	/* #675 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555084
	/* java_name */
	.ascii	"java/lang/Integer"
	.zero	100

	/* #676 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555080
	/* java_name */
	.ascii	"java/lang/Iterable"
	.zero	99

	/* #677 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555087
	/* java_name */
	.ascii	"java/lang/LinkageError"
	.zero	95

	/* #678 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555088
	/* java_name */
	.ascii	"java/lang/Long"
	.zero	103

	/* #679 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555089
	/* java_name */
	.ascii	"java/lang/NoClassDefFoundError"
	.zero	87

	/* #680 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555090
	/* java_name */
	.ascii	"java/lang/NullPointerException"
	.zero	87

	/* #681 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555091
	/* java_name */
	.ascii	"java/lang/Number"
	.zero	101

	/* #682 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555093
	/* java_name */
	.ascii	"java/lang/Object"
	.zero	101

	/* #683 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555094
	/* java_name */
	.ascii	"java/lang/ReflectiveOperationException"
	.zero	79

	/* #684 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555086
	/* java_name */
	.ascii	"java/lang/Runnable"
	.zero	99

	/* #685 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555095
	/* java_name */
	.ascii	"java/lang/RuntimeException"
	.zero	91

	/* #686 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555096
	/* java_name */
	.ascii	"java/lang/Short"
	.zero	102

	/* #687 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555097
	/* java_name */
	.ascii	"java/lang/String"
	.zero	101

	/* #688 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555099
	/* java_name */
	.ascii	"java/lang/Thread"
	.zero	101

	/* #689 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555101
	/* java_name */
	.ascii	"java/lang/Throwable"
	.zero	98

	/* #690 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555102
	/* java_name */
	.ascii	"java/lang/UnsupportedOperationException"
	.zero	78

	/* #691 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555115
	/* java_name */
	.ascii	"java/lang/annotation/Annotation"
	.zero	86

	/* #692 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555111
	/* java_name */
	.ascii	"java/lang/ref/Reference"
	.zero	94

	/* #693 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555113
	/* java_name */
	.ascii	"java/lang/ref/WeakReference"
	.zero	90

	/* #694 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555104
	/* java_name */
	.ascii	"java/lang/reflect/AnnotatedElement"
	.zero	83

	/* #695 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555106
	/* java_name */
	.ascii	"java/lang/reflect/GenericDeclaration"
	.zero	81

	/* #696 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555108
	/* java_name */
	.ascii	"java/lang/reflect/Type"
	.zero	95

	/* #697 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555110
	/* java_name */
	.ascii	"java/lang/reflect/TypeVariable"
	.zero	87

	/* #698 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555038
	/* java_name */
	.ascii	"java/net/ConnectException"
	.zero	92

	/* #699 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555039
	/* java_name */
	.ascii	"java/net/HttpURLConnection"
	.zero	91

	/* #700 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555041
	/* java_name */
	.ascii	"java/net/InetSocketAddress"
	.zero	91

	/* #701 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555042
	/* java_name */
	.ascii	"java/net/Proxy"
	.zero	103

	/* #702 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555043
	/* java_name */
	.ascii	"java/net/Proxy$Type"
	.zero	98

	/* #703 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555044
	/* java_name */
	.ascii	"java/net/ProxySelector"
	.zero	95

	/* #704 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555046
	/* java_name */
	.ascii	"java/net/SocketAddress"
	.zero	95

	/* #705 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555048
	/* java_name */
	.ascii	"java/net/SocketException"
	.zero	93

	/* #706 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555049
	/* java_name */
	.ascii	"java/net/URI"
	.zero	105

	/* #707 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555050
	/* java_name */
	.ascii	"java/net/URL"
	.zero	105

	/* #708 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555051
	/* java_name */
	.ascii	"java/net/URLConnection"
	.zero	95

	/* #709 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555014
	/* java_name */
	.ascii	"java/nio/Buffer"
	.zero	102

	/* #710 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555016
	/* java_name */
	.ascii	"java/nio/ByteBuffer"
	.zero	98

	/* #711 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555021
	/* java_name */
	.ascii	"java/nio/channels/ByteChannel"
	.zero	88

	/* #712 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555023
	/* java_name */
	.ascii	"java/nio/channels/Channel"
	.zero	92

	/* #713 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555018
	/* java_name */
	.ascii	"java/nio/channels/FileChannel"
	.zero	88

	/* #714 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555025
	/* java_name */
	.ascii	"java/nio/channels/GatheringByteChannel"
	.zero	79

	/* #715 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555027
	/* java_name */
	.ascii	"java/nio/channels/InterruptibleChannel"
	.zero	79

	/* #716 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555029
	/* java_name */
	.ascii	"java/nio/channels/ReadableByteChannel"
	.zero	80

	/* #717 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555031
	/* java_name */
	.ascii	"java/nio/channels/ScatteringByteChannel"
	.zero	78

	/* #718 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555033
	/* java_name */
	.ascii	"java/nio/channels/SeekableByteChannel"
	.zero	80

	/* #719 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555035
	/* java_name */
	.ascii	"java/nio/channels/WritableByteChannel"
	.zero	80

	/* #720 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555036
	/* java_name */
	.ascii	"java/nio/channels/spi/AbstractInterruptibleChannel"
	.zero	67

	/* #721 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554983
	/* java_name */
	.ascii	"java/security/GeneralSecurityException"
	.zero	79

	/* #722 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554985
	/* java_name */
	.ascii	"java/security/Key"
	.zero	100

	/* #723 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554990
	/* java_name */
	.ascii	"java/security/KeyFactory"
	.zero	93

	/* #724 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554991
	/* java_name */
	.ascii	"java/security/KeyStore"
	.zero	95

	/* #725 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554993
	/* java_name */
	.ascii	"java/security/KeyStore$LoadStoreParameter"
	.zero	76

	/* #726 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554995
	/* java_name */
	.ascii	"java/security/KeyStore$ProtectionParameter"
	.zero	75

	/* #727 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554996
	/* java_name */
	.ascii	"java/security/NoSuchAlgorithmException"
	.zero	79

	/* #728 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554987
	/* java_name */
	.ascii	"java/security/Principal"
	.zero	94

	/* #729 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554989
	/* java_name */
	.ascii	"java/security/PublicKey"
	.zero	94

	/* #730 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554997
	/* java_name */
	.ascii	"java/security/SecureRandom"
	.zero	91

	/* #731 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554998
	/* java_name */
	.ascii	"java/security/Signature"
	.zero	94

	/* #732 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555000
	/* java_name */
	.ascii	"java/security/SignatureSpi"
	.zero	91

	/* #733 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555007
	/* java_name */
	.ascii	"java/security/cert/Certificate"
	.zero	87

	/* #734 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555009
	/* java_name */
	.ascii	"java/security/cert/CertificateFactory"
	.zero	80

	/* #735 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555012
	/* java_name */
	.ascii	"java/security/cert/X509Certificate"
	.zero	83

	/* #736 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555011
	/* java_name */
	.ascii	"java/security/cert/X509Extension"
	.zero	85

	/* #737 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555002
	/* java_name */
	.ascii	"java/security/spec/EncodedKeySpec"
	.zero	84

	/* #738 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555005
	/* java_name */
	.ascii	"java/security/spec/KeySpec"
	.zero	91

	/* #739 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555006
	/* java_name */
	.ascii	"java/security/spec/X509EncodedKeySpec"
	.zero	80

	/* #740 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554978
	/* java_name */
	.ascii	"java/text/DecimalFormat"
	.zero	94

	/* #741 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554981
	/* java_name */
	.ascii	"java/text/Format"
	.zero	101

	/* #742 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554979
	/* java_name */
	.ascii	"java/text/NumberFormat"
	.zero	95

	/* #743 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554933
	/* java_name */
	.ascii	"java/util/ArrayList"
	.zero	98

	/* #744 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554922
	/* java_name */
	.ascii	"java/util/Collection"
	.zero	97

	/* #745 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554967
	/* java_name */
	.ascii	"java/util/Comparator"
	.zero	97

	/* #746 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554965
	/* java_name */
	.ascii	"java/util/Date"
	.zero	103

	/* #747 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554969
	/* java_name */
	.ascii	"java/util/Enumeration"
	.zero	96

	/* #748 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554924
	/* java_name */
	.ascii	"java/util/HashMap"
	.zero	100

	/* #749 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554942
	/* java_name */
	.ascii	"java/util/HashSet"
	.zero	100

	/* #750 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554971
	/* java_name */
	.ascii	"java/util/Iterator"
	.zero	99

	/* #751 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554972
	/* java_name */
	.ascii	"java/util/Random"
	.zero	101

	/* #752 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554974
	/* java_name */
	.ascii	"java/util/concurrent/Executor"
	.zero	88

	/* #753 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554976
	/* java_name */
	.ascii	"java/util/concurrent/Future"
	.zero	90

	/* #754 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554977
	/* java_name */
	.ascii	"java/util/concurrent/TimeUnit"
	.zero	88

	/* #755 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554464
	/* java_name */
	.ascii	"javax/net/SocketFactory"
	.zero	94

	/* #756 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554469
	/* java_name */
	.ascii	"javax/net/ssl/HostnameVerifier"
	.zero	87

	/* #757 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554466
	/* java_name */
	.ascii	"javax/net/ssl/HttpsURLConnection"
	.zero	85

	/* #758 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554471
	/* java_name */
	.ascii	"javax/net/ssl/KeyManager"
	.zero	93

	/* #759 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554480
	/* java_name */
	.ascii	"javax/net/ssl/KeyManagerFactory"
	.zero	86

	/* #760 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554481
	/* java_name */
	.ascii	"javax/net/ssl/SSLContext"
	.zero	93

	/* #761 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554473
	/* java_name */
	.ascii	"javax/net/ssl/SSLSession"
	.zero	93

	/* #762 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554475
	/* java_name */
	.ascii	"javax/net/ssl/SSLSessionContext"
	.zero	86

	/* #763 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554482
	/* java_name */
	.ascii	"javax/net/ssl/SSLSocketFactory"
	.zero	87

	/* #764 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554477
	/* java_name */
	.ascii	"javax/net/ssl/TrustManager"
	.zero	91

	/* #765 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554484
	/* java_name */
	.ascii	"javax/net/ssl/TrustManagerFactory"
	.zero	84

	/* #766 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554479
	/* java_name */
	.ascii	"javax/net/ssl/X509TrustManager"
	.zero	87

	/* #767 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554460
	/* java_name */
	.ascii	"javax/security/cert/Certificate"
	.zero	86

	/* #768 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554462
	/* java_name */
	.ascii	"javax/security/cert/X509Certificate"
	.zero	82

	/* #769 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555156
	/* java_name */
	.ascii	"mono/android/TypeManager"
	.zero	93

	/* #770 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554861
	/* java_name */
	.ascii	"mono/android/content/DialogInterface_OnDismissListenerImplementor"
	.zero	52

	/* #771 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554918
	/* java_name */
	.ascii	"mono/android/runtime/InputStreamAdapter"
	.zero	78

	/* #772 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	0
	/* java_name */
	.ascii	"mono/android/runtime/JavaArray"
	.zero	87

	/* #773 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554939
	/* java_name */
	.ascii	"mono/android/runtime/JavaObject"
	.zero	86

	/* #774 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554957
	/* java_name */
	.ascii	"mono/android/runtime/OutputStreamAdapter"
	.zero	77

	/* #775 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554696
	/* java_name */
	.ascii	"mono/android/text/TextWatcherImplementor"
	.zero	77

	/* #776 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554597
	/* java_name */
	.ascii	"mono/android/view/View_OnClickListenerImplementor"
	.zero	68

	/* #777 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554603
	/* java_name */
	.ascii	"mono/android/view/View_OnTouchListenerImplementor"
	.zero	68

	/* #778 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554526
	/* java_name */
	.ascii	"mono/android/widget/TextView_OnEditorActionListenerImplementor"
	.zero	55

	/* #779 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554441
	/* java_name */
	.ascii	"mono/androidx/appcompat/app/ActionBar_OnMenuVisibilityListenerImplementor"
	.zero	44

	/* #780 */
	/* module_index */
	.long	15
	/* type_token_id */
	.long	33554467
	/* java_name */
	.ascii	"mono/androidx/appcompat/widget/Toolbar_OnMenuItemClickListenerImplementor"
	.zero	44

	/* #781 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554454
	/* java_name */
	.ascii	"mono/androidx/core/view/ActionProvider_SubUiVisibilityListenerImplementor"
	.zero	44

	/* #782 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554458
	/* java_name */
	.ascii	"mono/androidx/core/view/ActionProvider_VisibilityListenerImplementor"
	.zero	49

	/* #783 */
	/* module_index */
	.long	17
	/* type_token_id */
	.long	33554445
	/* java_name */
	.ascii	"mono/androidx/core/widget/NestedScrollView_OnScrollChangeListenerImplementor"
	.zero	41

	/* #784 */
	/* module_index */
	.long	10
	/* type_token_id */
	.long	33554442
	/* java_name */
	.ascii	"mono/androidx/drawerlayout/widget/DrawerLayout_DrawerListenerImplementor"
	.zero	45

	/* #785 */
	/* module_index */
	.long	9
	/* type_token_id */
	.long	33554447
	/* java_name */
	.ascii	"mono/androidx/fragment/app/FragmentManager_OnBackStackChangedListenerImplementor"
	.zero	37

	/* #786 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554476
	/* java_name */
	.ascii	"mono/androidx/recyclerview/widget/RecyclerView_OnChildAttachStateChangeListenerImplementor"
	.zero	27

	/* #787 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554484
	/* java_name */
	.ascii	"mono/androidx/recyclerview/widget/RecyclerView_OnItemTouchListenerImplementor"
	.zero	40

	/* #788 */
	/* module_index */
	.long	6
	/* type_token_id */
	.long	33554492
	/* java_name */
	.ascii	"mono/androidx/recyclerview/widget/RecyclerView_RecyclerListenerImplementor"
	.zero	43

	/* #789 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554447
	/* java_name */
	.ascii	"mono/com/google/android/material/behavior/SwipeDismissBehavior_OnDismissListenerImplementor"
	.zero	26

	/* #790 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554464
	/* java_name */
	.ascii	"mono/com/google/android/material/bottomnavigation/BottomNavigationView_OnNavigationItemReselectedListenerImplementor"
	.zero	1

	/* #791 */
	/* module_index */
	.long	24
	/* type_token_id */
	.long	33554468
	/* java_name */
	.ascii	"mono/com/google/android/material/bottomnavigation/BottomNavigationView_OnNavigationItemSelectedListenerImplementor"
	.zero	3

	/* #792 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33555100
	/* java_name */
	.ascii	"mono/java/lang/RunnableImplementor"
	.zero	83

	/* #793 */
	/* module_index */
	.long	3
	/* type_token_id */
	.long	33554456
	/* java_name */
	.ascii	"xamarin/android/net/OldAndroidSSLSocketFactory"
	.zero	71

	/* #794 */
	/* module_index */
	.long	13
	/* type_token_id */
	.long	33554460
	/* java_name */
	.ascii	"xamarin/essentials/fileProvider"
	.zero	86

	.size	map_java, 99375
/* Java to managed map: END */

