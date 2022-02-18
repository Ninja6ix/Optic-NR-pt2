using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x0200000D RID: 13
	public enum SYSTEM_INFORMATION_CLASS
	{
		// Token: 0x040001F3 RID: 499
		SystemBasicInformation,
		// Token: 0x040001F4 RID: 500
		SystemProcessorInformation,
		// Token: 0x040001F5 RID: 501
		SystemPerformanceInformation,
		// Token: 0x040001F6 RID: 502
		SystemTimeOfDayInformation,
		// Token: 0x040001F7 RID: 503
		SystemPathInformation,
		// Token: 0x040001F8 RID: 504
		SystemProcessInformation,
		// Token: 0x040001F9 RID: 505
		SystemCallCountInformation,
		// Token: 0x040001FA RID: 506
		SystemDeviceInformation,
		// Token: 0x040001FB RID: 507
		SystemProcessorPerformanceInformation,
		// Token: 0x040001FC RID: 508
		SystemFlagsInformation,
		// Token: 0x040001FD RID: 509
		SystemCallTimeInformation,
		// Token: 0x040001FE RID: 510
		SystemModuleInformation,
		// Token: 0x040001FF RID: 511
		SystemLocksInformation,
		// Token: 0x04000200 RID: 512
		SystemStackTraceInformation,
		// Token: 0x04000201 RID: 513
		SystemPagedPoolInformation,
		// Token: 0x04000202 RID: 514
		SystemNonPagedPoolInformation,
		// Token: 0x04000203 RID: 515
		SystemHandleInformation,
		// Token: 0x04000204 RID: 516
		SystemObjectInformation,
		// Token: 0x04000205 RID: 517
		SystemPageFileInformation,
		// Token: 0x04000206 RID: 518
		SystemVdmInstemulInformation,
		// Token: 0x04000207 RID: 519
		SystemVdmBopInformation,
		// Token: 0x04000208 RID: 520
		SystemFileCacheInformation,
		// Token: 0x04000209 RID: 521
		SystemPoolTagInformation,
		// Token: 0x0400020A RID: 522
		SystemInterruptInformation,
		// Token: 0x0400020B RID: 523
		SystemDpcBehaviorInformation,
		// Token: 0x0400020C RID: 524
		SystemFullMemoryInformation,
		// Token: 0x0400020D RID: 525
		SystemLoadGdiDriverInformation,
		// Token: 0x0400020E RID: 526
		SystemUnloadGdiDriverInformation,
		// Token: 0x0400020F RID: 527
		SystemTimeAdjustmentInformation,
		// Token: 0x04000210 RID: 528
		SystemSummaryMemoryInformation,
		// Token: 0x04000211 RID: 529
		SystemMirrorMemoryInformation,
		// Token: 0x04000212 RID: 530
		SystemPerformanceTraceInformation,
		// Token: 0x04000213 RID: 531
		SystemObsolete0,
		// Token: 0x04000214 RID: 532
		SystemExceptionInformation,
		// Token: 0x04000215 RID: 533
		SystemCrashDumpStateInformation,
		// Token: 0x04000216 RID: 534
		SystemKernelDebuggerInformation,
		// Token: 0x04000217 RID: 535
		SystemContextSwitchInformation,
		// Token: 0x04000218 RID: 536
		SystemRegistryQuotaInformation,
		// Token: 0x04000219 RID: 537
		SystemExtendServiceTableInformation,
		// Token: 0x0400021A RID: 538
		SystemPrioritySeperation,
		// Token: 0x0400021B RID: 539
		SystemVerifierAddDriverInformation,
		// Token: 0x0400021C RID: 540
		SystemVerifierRemoveDriverInformation,
		// Token: 0x0400021D RID: 541
		SystemProcessorIdleInformation,
		// Token: 0x0400021E RID: 542
		SystemLegacyDriverInformation,
		// Token: 0x0400021F RID: 543
		SystemCurrentTimeZoneInformation,
		// Token: 0x04000220 RID: 544
		SystemLookasideInformation,
		// Token: 0x04000221 RID: 545
		SystemTimeSlipNotification,
		// Token: 0x04000222 RID: 546
		SystemSessionCreate,
		// Token: 0x04000223 RID: 547
		SystemSessionDetach,
		// Token: 0x04000224 RID: 548
		SystemSessionInformation,
		// Token: 0x04000225 RID: 549
		SystemRangeStartInformation,
		// Token: 0x04000226 RID: 550
		SystemVerifierInformation,
		// Token: 0x04000227 RID: 551
		SystemVerifierThunkExtend,
		// Token: 0x04000228 RID: 552
		SystemSessionProcessInformation,
		// Token: 0x04000229 RID: 553
		SystemLoadGdiDriverInSystemSpace,
		// Token: 0x0400022A RID: 554
		SystemNumaProcessorMap,
		// Token: 0x0400022B RID: 555
		SystemPrefetcherInformation,
		// Token: 0x0400022C RID: 556
		SystemExtendedProcessInformation,
		// Token: 0x0400022D RID: 557
		SystemRecommendedSharedDataAlignment,
		// Token: 0x0400022E RID: 558
		SystemComPlusPackage,
		// Token: 0x0400022F RID: 559
		SystemNumaAvailableMemory,
		// Token: 0x04000230 RID: 560
		SystemProcessorPowerInformation,
		// Token: 0x04000231 RID: 561
		SystemEmulationBasicInformation,
		// Token: 0x04000232 RID: 562
		SystemEmulationProcessorInformation,
		// Token: 0x04000233 RID: 563
		SystemExtendedHandleInformation,
		// Token: 0x04000234 RID: 564
		SystemLostDelayedWriteInformation,
		// Token: 0x04000235 RID: 565
		SystemBigPoolInformation,
		// Token: 0x04000236 RID: 566
		SystemSessionPoolTagInformation,
		// Token: 0x04000237 RID: 567
		SystemSessionMappedViewInformation,
		// Token: 0x04000238 RID: 568
		SystemHotpatchInformation,
		// Token: 0x04000239 RID: 569
		SystemObjectSecurityMode,
		// Token: 0x0400023A RID: 570
		SystemWatchdogTimerHandler,
		// Token: 0x0400023B RID: 571
		SystemWatchdogTimerInformation,
		// Token: 0x0400023C RID: 572
		SystemLogicalProcessorInformation,
		// Token: 0x0400023D RID: 573
		SystemWow64SharedInformationObsolete,
		// Token: 0x0400023E RID: 574
		SystemRegisterFirmwareTableInformationHandler,
		// Token: 0x0400023F RID: 575
		SystemFirmwareTableInformation,
		// Token: 0x04000240 RID: 576
		SystemModuleInformationEx,
		// Token: 0x04000241 RID: 577
		SystemVerifierTriageInformation,
		// Token: 0x04000242 RID: 578
		SystemSuperfetchInformation,
		// Token: 0x04000243 RID: 579
		SystemMemoryListInformation,
		// Token: 0x04000244 RID: 580
		SystemFileCacheInformationEx,
		// Token: 0x04000245 RID: 581
		SystemThreadPriorityClientIdInformation,
		// Token: 0x04000246 RID: 582
		SystemProcessorIdleCycleTimeInformation,
		// Token: 0x04000247 RID: 583
		SystemVerifierCancellationInformation,
		// Token: 0x04000248 RID: 584
		SystemProcessorPowerInformationEx,
		// Token: 0x04000249 RID: 585
		SystemRefTraceInformation,
		// Token: 0x0400024A RID: 586
		SystemSpecialPoolInformation,
		// Token: 0x0400024B RID: 587
		SystemProcessIdInformation,
		// Token: 0x0400024C RID: 588
		SystemErrorPortInformation,
		// Token: 0x0400024D RID: 589
		SystemBootEnvironmentInformation,
		// Token: 0x0400024E RID: 590
		SystemHypervisorInformation,
		// Token: 0x0400024F RID: 591
		SystemVerifierInformationEx,
		// Token: 0x04000250 RID: 592
		SystemTimeZoneInformation,
		// Token: 0x04000251 RID: 593
		SystemImageFileExecutionOptionsInformation,
		// Token: 0x04000252 RID: 594
		SystemCoverageInformation,
		// Token: 0x04000253 RID: 595
		SystemPrefetchPatchInformation,
		// Token: 0x04000254 RID: 596
		SystemVerifierFaultsInformation,
		// Token: 0x04000255 RID: 597
		SystemSystemPartitionInformation,
		// Token: 0x04000256 RID: 598
		SystemSystemDiskInformation,
		// Token: 0x04000257 RID: 599
		SystemProcessorPerformanceDistribution,
		// Token: 0x04000258 RID: 600
		SystemNumaProximityNodeInformation,
		// Token: 0x04000259 RID: 601
		SystemDynamicTimeZoneInformation,
		// Token: 0x0400025A RID: 602
		SystemCodeIntegrityInformation,
		// Token: 0x0400025B RID: 603
		SystemProcessorMicrocodeUpdateInformation,
		// Token: 0x0400025C RID: 604
		SystemProcessorBrandString,
		// Token: 0x0400025D RID: 605
		SystemVirtualAddressInformation,
		// Token: 0x0400025E RID: 606
		SystemLogicalProcessorAndGroupInformation,
		// Token: 0x0400025F RID: 607
		SystemProcessorCycleTimeInformation,
		// Token: 0x04000260 RID: 608
		SystemStoreInformation,
		// Token: 0x04000261 RID: 609
		SystemRegistryAppendString,
		// Token: 0x04000262 RID: 610
		SystemAitSamplingValue,
		// Token: 0x04000263 RID: 611
		SystemVhdBootInformation,
		// Token: 0x04000264 RID: 612
		SystemCpuQuotaInformation,
		// Token: 0x04000265 RID: 613
		SystemNativeBasicInformation,
		// Token: 0x04000266 RID: 614
		SystemSpare1,
		// Token: 0x04000267 RID: 615
		SystemLowPriorityIoInformation,
		// Token: 0x04000268 RID: 616
		SystemTpmBootEntropyInformation,
		// Token: 0x04000269 RID: 617
		SystemVerifierCountersInformation,
		// Token: 0x0400026A RID: 618
		SystemPagedPoolInformationEx,
		// Token: 0x0400026B RID: 619
		SystemSystemPtesInformationEx,
		// Token: 0x0400026C RID: 620
		SystemNodeDistanceInformation,
		// Token: 0x0400026D RID: 621
		SystemAcpiAuditInformation,
		// Token: 0x0400026E RID: 622
		SystemBasicPerformanceInformation,
		// Token: 0x0400026F RID: 623
		SystemQueryPerformanceCounterInformation,
		// Token: 0x04000270 RID: 624
		SystemSessionBigPoolInformation,
		// Token: 0x04000271 RID: 625
		SystemBootGraphicsInformation,
		// Token: 0x04000272 RID: 626
		SystemScrubPhysicalMemoryInformation,
		// Token: 0x04000273 RID: 627
		SystemBadPageInformation,
		// Token: 0x04000274 RID: 628
		SystemProcessorProfileControlArea,
		// Token: 0x04000275 RID: 629
		SystemCombinePhysicalMemoryInformation,
		// Token: 0x04000276 RID: 630
		SystemEntropyInterruptTimingCallback,
		// Token: 0x04000277 RID: 631
		SystemConsoleInformation,
		// Token: 0x04000278 RID: 632
		SystemPlatformBinaryInformation,
		// Token: 0x04000279 RID: 633
		SystemThrottleNotificationInformation,
		// Token: 0x0400027A RID: 634
		SystemHypervisorProcessorCountInformation,
		// Token: 0x0400027B RID: 635
		SystemDeviceDataInformation,
		// Token: 0x0400027C RID: 636
		SystemDeviceDataEnumerationInformation,
		// Token: 0x0400027D RID: 637
		SystemMemoryTopologyInformation,
		// Token: 0x0400027E RID: 638
		SystemMemoryChannelInformation,
		// Token: 0x0400027F RID: 639
		SystemBootLogoInformation,
		// Token: 0x04000280 RID: 640
		SystemProcessorPerformanceInformationEx,
		// Token: 0x04000281 RID: 641
		SystemSpare0,
		// Token: 0x04000282 RID: 642
		SystemSecureBootPolicyInformation,
		// Token: 0x04000283 RID: 643
		SystemPageFileInformationEx,
		// Token: 0x04000284 RID: 644
		SystemSecureBootInformation,
		// Token: 0x04000285 RID: 645
		SystemEntropyInterruptTimingRawInformation,
		// Token: 0x04000286 RID: 646
		SystemPortableWorkspaceEfiLauncherInformation,
		// Token: 0x04000287 RID: 647
		SystemFullProcessInformation,
		// Token: 0x04000288 RID: 648
		SystemKernelDebuggerInformationEx,
		// Token: 0x04000289 RID: 649
		SystemBootMetadataInformation,
		// Token: 0x0400028A RID: 650
		SystemSoftRebootInformation,
		// Token: 0x0400028B RID: 651
		SystemElamCertificateInformation,
		// Token: 0x0400028C RID: 652
		SystemOfflineDumpConfigInformation,
		// Token: 0x0400028D RID: 653
		SystemProcessorFeaturesInformation,
		// Token: 0x0400028E RID: 654
		SystemRegistryReconciliationInformation,
		// Token: 0x0400028F RID: 655
		SystemEdidInformation,
		// Token: 0x04000290 RID: 656
		MaxSystemInfoClass
	}
}
