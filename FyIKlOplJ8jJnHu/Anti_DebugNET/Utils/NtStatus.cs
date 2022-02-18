﻿using System;

namespace Anti_DebugNET.Utils
{
	// Token: 0x0200000A RID: 10
	public enum NtStatus : uint
	{
		// Token: 0x04000065 RID: 101
		Success,
		// Token: 0x04000066 RID: 102
		Wait0 = 0U,
		// Token: 0x04000067 RID: 103
		Wait1,
		// Token: 0x04000068 RID: 104
		Wait2,
		// Token: 0x04000069 RID: 105
		Wait3,
		// Token: 0x0400006A RID: 106
		Wait63 = 63U,
		// Token: 0x0400006B RID: 107
		Abandoned = 128U,
		// Token: 0x0400006C RID: 108
		AbandonedWait0 = 128U,
		// Token: 0x0400006D RID: 109
		AbandonedWait1,
		// Token: 0x0400006E RID: 110
		AbandonedWait2,
		// Token: 0x0400006F RID: 111
		AbandonedWait3,
		// Token: 0x04000070 RID: 112
		AbandonedWait63 = 191U,
		// Token: 0x04000071 RID: 113
		UserApc,
		// Token: 0x04000072 RID: 114
		KernelApc = 256U,
		// Token: 0x04000073 RID: 115
		Alerted,
		// Token: 0x04000074 RID: 116
		Timeout,
		// Token: 0x04000075 RID: 117
		Pending,
		// Token: 0x04000076 RID: 118
		Reparse,
		// Token: 0x04000077 RID: 119
		MoreEntries,
		// Token: 0x04000078 RID: 120
		NotAllAssigned,
		// Token: 0x04000079 RID: 121
		SomeNotMapped,
		// Token: 0x0400007A RID: 122
		OpLockBreakInProgress,
		// Token: 0x0400007B RID: 123
		VolumeMounted,
		// Token: 0x0400007C RID: 124
		RxActCommitted,
		// Token: 0x0400007D RID: 125
		NotifyCleanup,
		// Token: 0x0400007E RID: 126
		NotifyEnumDir,
		// Token: 0x0400007F RID: 127
		NoQuotasForAccount,
		// Token: 0x04000080 RID: 128
		PrimaryTransportConnectFailed,
		// Token: 0x04000081 RID: 129
		PageFaultTransition = 272U,
		// Token: 0x04000082 RID: 130
		PageFaultDemandZero,
		// Token: 0x04000083 RID: 131
		PageFaultCopyOnWrite,
		// Token: 0x04000084 RID: 132
		PageFaultGuardPage,
		// Token: 0x04000085 RID: 133
		PageFaultPagingFile,
		// Token: 0x04000086 RID: 134
		CrashDump = 278U,
		// Token: 0x04000087 RID: 135
		ReparseObject = 280U,
		// Token: 0x04000088 RID: 136
		NothingToTerminate = 290U,
		// Token: 0x04000089 RID: 137
		ProcessNotInJob,
		// Token: 0x0400008A RID: 138
		ProcessInJob,
		// Token: 0x0400008B RID: 139
		ProcessCloned = 297U,
		// Token: 0x0400008C RID: 140
		FileLockedWithOnlyReaders,
		// Token: 0x0400008D RID: 141
		FileLockedWithWriters,
		// Token: 0x0400008E RID: 142
		Informational = 1073741824U,
		// Token: 0x0400008F RID: 143
		ObjectNameExists = 1073741824U,
		// Token: 0x04000090 RID: 144
		ThreadWasSuspended,
		// Token: 0x04000091 RID: 145
		WorkingSetLimitRange,
		// Token: 0x04000092 RID: 146
		ImageNotAtBase,
		// Token: 0x04000093 RID: 147
		RegistryRecovered = 1073741833U,
		// Token: 0x04000094 RID: 148
		Warning = 2147483648U,
		// Token: 0x04000095 RID: 149
		GuardPageViolation,
		// Token: 0x04000096 RID: 150
		DatatypeMisalignment,
		// Token: 0x04000097 RID: 151
		Breakpoint,
		// Token: 0x04000098 RID: 152
		SingleStep,
		// Token: 0x04000099 RID: 153
		BufferOverflow,
		// Token: 0x0400009A RID: 154
		NoMoreFiles,
		// Token: 0x0400009B RID: 155
		HandlesClosed = 2147483658U,
		// Token: 0x0400009C RID: 156
		PartialCopy = 2147483661U,
		// Token: 0x0400009D RID: 157
		DeviceBusy = 2147483665U,
		// Token: 0x0400009E RID: 158
		InvalidEaName = 2147483667U,
		// Token: 0x0400009F RID: 159
		EaListInconsistent,
		// Token: 0x040000A0 RID: 160
		NoMoreEntries = 2147483674U,
		// Token: 0x040000A1 RID: 161
		LongJump = 2147483686U,
		// Token: 0x040000A2 RID: 162
		DllMightBeInsecure = 2147483691U,
		// Token: 0x040000A3 RID: 163
		Error = 3221225472U,
		// Token: 0x040000A4 RID: 164
		Unsuccessful,
		// Token: 0x040000A5 RID: 165
		NotImplemented,
		// Token: 0x040000A6 RID: 166
		InvalidInfoClass,
		// Token: 0x040000A7 RID: 167
		InfoLengthMismatch,
		// Token: 0x040000A8 RID: 168
		AccessViolation,
		// Token: 0x040000A9 RID: 169
		InPageError,
		// Token: 0x040000AA RID: 170
		PagefileQuota,
		// Token: 0x040000AB RID: 171
		InvalidHandle,
		// Token: 0x040000AC RID: 172
		BadInitialStack,
		// Token: 0x040000AD RID: 173
		BadInitialPc,
		// Token: 0x040000AE RID: 174
		InvalidCid,
		// Token: 0x040000AF RID: 175
		TimerNotCanceled,
		// Token: 0x040000B0 RID: 176
		InvalidParameter,
		// Token: 0x040000B1 RID: 177
		NoSuchDevice,
		// Token: 0x040000B2 RID: 178
		NoSuchFile,
		// Token: 0x040000B3 RID: 179
		InvalidDeviceRequest,
		// Token: 0x040000B4 RID: 180
		EndOfFile,
		// Token: 0x040000B5 RID: 181
		WrongVolume,
		// Token: 0x040000B6 RID: 182
		NoMediaInDevice,
		// Token: 0x040000B7 RID: 183
		NoMemory = 3221225495U,
		// Token: 0x040000B8 RID: 184
		NotMappedView = 3221225497U,
		// Token: 0x040000B9 RID: 185
		UnableToFreeVm,
		// Token: 0x040000BA RID: 186
		UnableToDeleteSection,
		// Token: 0x040000BB RID: 187
		IllegalInstruction = 3221225501U,
		// Token: 0x040000BC RID: 188
		AlreadyCommitted = 3221225505U,
		// Token: 0x040000BD RID: 189
		AccessDenied,
		// Token: 0x040000BE RID: 190
		BufferTooSmall,
		// Token: 0x040000BF RID: 191
		ObjectTypeMismatch,
		// Token: 0x040000C0 RID: 192
		NonContinuableException,
		// Token: 0x040000C1 RID: 193
		BadStack = 3221225512U,
		// Token: 0x040000C2 RID: 194
		NotLocked = 3221225514U,
		// Token: 0x040000C3 RID: 195
		NotCommitted = 3221225517U,
		// Token: 0x040000C4 RID: 196
		InvalidParameterMix = 3221225520U,
		// Token: 0x040000C5 RID: 197
		ObjectNameInvalid = 3221225523U,
		// Token: 0x040000C6 RID: 198
		ObjectNameNotFound,
		// Token: 0x040000C7 RID: 199
		ObjectNameCollision,
		// Token: 0x040000C8 RID: 200
		ObjectPathInvalid = 3221225529U,
		// Token: 0x040000C9 RID: 201
		ObjectPathNotFound,
		// Token: 0x040000CA RID: 202
		ObjectPathSyntaxBad,
		// Token: 0x040000CB RID: 203
		DataOverrun,
		// Token: 0x040000CC RID: 204
		DataLate,
		// Token: 0x040000CD RID: 205
		DataError,
		// Token: 0x040000CE RID: 206
		CrcError,
		// Token: 0x040000CF RID: 207
		SectionTooBig,
		// Token: 0x040000D0 RID: 208
		PortConnectionRefused,
		// Token: 0x040000D1 RID: 209
		InvalidPortHandle,
		// Token: 0x040000D2 RID: 210
		SharingViolation,
		// Token: 0x040000D3 RID: 211
		QuotaExceeded,
		// Token: 0x040000D4 RID: 212
		InvalidPageProtection,
		// Token: 0x040000D5 RID: 213
		MutantNotOwned,
		// Token: 0x040000D6 RID: 214
		SemaphoreLimitExceeded,
		// Token: 0x040000D7 RID: 215
		PortAlreadySet,
		// Token: 0x040000D8 RID: 216
		SectionNotImage,
		// Token: 0x040000D9 RID: 217
		SuspendCountExceeded,
		// Token: 0x040000DA RID: 218
		ThreadIsTerminating,
		// Token: 0x040000DB RID: 219
		BadWorkingSetLimit,
		// Token: 0x040000DC RID: 220
		IncompatibleFileMap,
		// Token: 0x040000DD RID: 221
		SectionProtection,
		// Token: 0x040000DE RID: 222
		EasNotSupported,
		// Token: 0x040000DF RID: 223
		EaTooLarge,
		// Token: 0x040000E0 RID: 224
		NonExistentEaEntry,
		// Token: 0x040000E1 RID: 225
		NoEasOnFile,
		// Token: 0x040000E2 RID: 226
		EaCorruptError,
		// Token: 0x040000E3 RID: 227
		FileLockConflict,
		// Token: 0x040000E4 RID: 228
		LockNotGranted,
		// Token: 0x040000E5 RID: 229
		DeletePending,
		// Token: 0x040000E6 RID: 230
		CtlFileNotSupported,
		// Token: 0x040000E7 RID: 231
		UnknownRevision,
		// Token: 0x040000E8 RID: 232
		RevisionMismatch,
		// Token: 0x040000E9 RID: 233
		InvalidOwner,
		// Token: 0x040000EA RID: 234
		InvalidPrimaryGroup,
		// Token: 0x040000EB RID: 235
		NoImpersonationToken,
		// Token: 0x040000EC RID: 236
		CantDisableMandatory,
		// Token: 0x040000ED RID: 237
		NoLogonServers,
		// Token: 0x040000EE RID: 238
		NoSuchLogonSession,
		// Token: 0x040000EF RID: 239
		NoSuchPrivilege,
		// Token: 0x040000F0 RID: 240
		PrivilegeNotHeld,
		// Token: 0x040000F1 RID: 241
		InvalidAccountName,
		// Token: 0x040000F2 RID: 242
		UserExists,
		// Token: 0x040000F3 RID: 243
		NoSuchUser,
		// Token: 0x040000F4 RID: 244
		GroupExists,
		// Token: 0x040000F5 RID: 245
		NoSuchGroup,
		// Token: 0x040000F6 RID: 246
		MemberInGroup,
		// Token: 0x040000F7 RID: 247
		MemberNotInGroup,
		// Token: 0x040000F8 RID: 248
		LastAdmin,
		// Token: 0x040000F9 RID: 249
		WrongPassword,
		// Token: 0x040000FA RID: 250
		IllFormedPassword,
		// Token: 0x040000FB RID: 251
		PasswordRestriction,
		// Token: 0x040000FC RID: 252
		LogonFailure,
		// Token: 0x040000FD RID: 253
		AccountRestriction,
		// Token: 0x040000FE RID: 254
		InvalidLogonHours,
		// Token: 0x040000FF RID: 255
		InvalidWorkstation,
		// Token: 0x04000100 RID: 256
		PasswordExpired,
		// Token: 0x04000101 RID: 257
		AccountDisabled,
		// Token: 0x04000102 RID: 258
		NoneMapped,
		// Token: 0x04000103 RID: 259
		TooManyLuidsRequested,
		// Token: 0x04000104 RID: 260
		LuidsExhausted,
		// Token: 0x04000105 RID: 261
		InvalidSubAuthority,
		// Token: 0x04000106 RID: 262
		InvalidAcl,
		// Token: 0x04000107 RID: 263
		InvalidSid,
		// Token: 0x04000108 RID: 264
		InvalidSecurityDescr,
		// Token: 0x04000109 RID: 265
		ProcedureNotFound,
		// Token: 0x0400010A RID: 266
		InvalidImageFormat,
		// Token: 0x0400010B RID: 267
		NoToken,
		// Token: 0x0400010C RID: 268
		BadInheritanceAcl,
		// Token: 0x0400010D RID: 269
		RangeNotLocked,
		// Token: 0x0400010E RID: 270
		DiskFull,
		// Token: 0x0400010F RID: 271
		ServerDisabled,
		// Token: 0x04000110 RID: 272
		ServerNotDisabled,
		// Token: 0x04000111 RID: 273
		TooManyGuidsRequested,
		// Token: 0x04000112 RID: 274
		GuidsExhausted,
		// Token: 0x04000113 RID: 275
		InvalidIdAuthority,
		// Token: 0x04000114 RID: 276
		AgentsExhausted,
		// Token: 0x04000115 RID: 277
		InvalidVolumeLabel,
		// Token: 0x04000116 RID: 278
		SectionNotExtended,
		// Token: 0x04000117 RID: 279
		NotMappedData,
		// Token: 0x04000118 RID: 280
		ResourceDataNotFound,
		// Token: 0x04000119 RID: 281
		ResourceTypeNotFound,
		// Token: 0x0400011A RID: 282
		ResourceNameNotFound,
		// Token: 0x0400011B RID: 283
		ArrayBoundsExceeded,
		// Token: 0x0400011C RID: 284
		FloatDenormalOperand,
		// Token: 0x0400011D RID: 285
		FloatDivideByZero,
		// Token: 0x0400011E RID: 286
		FloatInexactResult,
		// Token: 0x0400011F RID: 287
		FloatInvalidOperation,
		// Token: 0x04000120 RID: 288
		FloatOverflow,
		// Token: 0x04000121 RID: 289
		FloatStackCheck,
		// Token: 0x04000122 RID: 290
		FloatUnderflow,
		// Token: 0x04000123 RID: 291
		IntegerDivideByZero,
		// Token: 0x04000124 RID: 292
		IntegerOverflow,
		// Token: 0x04000125 RID: 293
		PrivilegedInstruction,
		// Token: 0x04000126 RID: 294
		TooManyPagingFiles,
		// Token: 0x04000127 RID: 295
		FileInvalid,
		// Token: 0x04000128 RID: 296
		InstanceNotAvailable = 3221225643U,
		// Token: 0x04000129 RID: 297
		PipeNotAvailable,
		// Token: 0x0400012A RID: 298
		InvalidPipeState,
		// Token: 0x0400012B RID: 299
		PipeBusy,
		// Token: 0x0400012C RID: 300
		IllegalFunction,
		// Token: 0x0400012D RID: 301
		PipeDisconnected,
		// Token: 0x0400012E RID: 302
		PipeClosing,
		// Token: 0x0400012F RID: 303
		PipeConnected,
		// Token: 0x04000130 RID: 304
		PipeListening,
		// Token: 0x04000131 RID: 305
		InvalidReadMode,
		// Token: 0x04000132 RID: 306
		IoTimeout,
		// Token: 0x04000133 RID: 307
		FileForcedClosed,
		// Token: 0x04000134 RID: 308
		ProfilingNotStarted,
		// Token: 0x04000135 RID: 309
		ProfilingNotStopped,
		// Token: 0x04000136 RID: 310
		NotSameDevice = 3221225684U,
		// Token: 0x04000137 RID: 311
		FileRenamed,
		// Token: 0x04000138 RID: 312
		CantWait = 3221225688U,
		// Token: 0x04000139 RID: 313
		PipeEmpty,
		// Token: 0x0400013A RID: 314
		CantTerminateSelf = 3221225691U,
		// Token: 0x0400013B RID: 315
		InternalError = 3221225701U,
		// Token: 0x0400013C RID: 316
		InvalidParameter1 = 3221225711U,
		// Token: 0x0400013D RID: 317
		InvalidParameter2,
		// Token: 0x0400013E RID: 318
		InvalidParameter3,
		// Token: 0x0400013F RID: 319
		InvalidParameter4,
		// Token: 0x04000140 RID: 320
		InvalidParameter5,
		// Token: 0x04000141 RID: 321
		InvalidParameter6,
		// Token: 0x04000142 RID: 322
		InvalidParameter7,
		// Token: 0x04000143 RID: 323
		InvalidParameter8,
		// Token: 0x04000144 RID: 324
		InvalidParameter9,
		// Token: 0x04000145 RID: 325
		InvalidParameter10,
		// Token: 0x04000146 RID: 326
		InvalidParameter11,
		// Token: 0x04000147 RID: 327
		InvalidParameter12,
		// Token: 0x04000148 RID: 328
		MappedFileSizeZero = 3221225758U,
		// Token: 0x04000149 RID: 329
		TooManyOpenedFiles,
		// Token: 0x0400014A RID: 330
		Cancelled,
		// Token: 0x0400014B RID: 331
		CannotDelete,
		// Token: 0x0400014C RID: 332
		InvalidComputerName,
		// Token: 0x0400014D RID: 333
		FileDeleted,
		// Token: 0x0400014E RID: 334
		SpecialAccount,
		// Token: 0x0400014F RID: 335
		SpecialGroup,
		// Token: 0x04000150 RID: 336
		SpecialUser,
		// Token: 0x04000151 RID: 337
		MembersPrimaryGroup,
		// Token: 0x04000152 RID: 338
		FileClosed,
		// Token: 0x04000153 RID: 339
		TooManyThreads,
		// Token: 0x04000154 RID: 340
		ThreadNotInProcess,
		// Token: 0x04000155 RID: 341
		TokenAlreadyInUse,
		// Token: 0x04000156 RID: 342
		PagefileQuotaExceeded,
		// Token: 0x04000157 RID: 343
		CommitmentLimit,
		// Token: 0x04000158 RID: 344
		InvalidImageLeFormat,
		// Token: 0x04000159 RID: 345
		InvalidImageNotMz,
		// Token: 0x0400015A RID: 346
		InvalidImageProtect,
		// Token: 0x0400015B RID: 347
		InvalidImageWin16,
		// Token: 0x0400015C RID: 348
		LogonServer,
		// Token: 0x0400015D RID: 349
		DifferenceAtDc,
		// Token: 0x0400015E RID: 350
		SynchronizationRequired,
		// Token: 0x0400015F RID: 351
		DllNotFound,
		// Token: 0x04000160 RID: 352
		IoPrivilegeFailed = 3221225783U,
		// Token: 0x04000161 RID: 353
		OrdinalNotFound,
		// Token: 0x04000162 RID: 354
		EntryPointNotFound,
		// Token: 0x04000163 RID: 355
		ControlCExit,
		// Token: 0x04000164 RID: 356
		PortNotSet = 3221226323U,
		// Token: 0x04000165 RID: 357
		DebuggerInactive,
		// Token: 0x04000166 RID: 358
		CallbackBypass = 3221226755U,
		// Token: 0x04000167 RID: 359
		PortClosed = 3221227264U,
		// Token: 0x04000168 RID: 360
		MessageLost,
		// Token: 0x04000169 RID: 361
		InvalidMessage,
		// Token: 0x0400016A RID: 362
		RequestCanceled,
		// Token: 0x0400016B RID: 363
		RecursiveDispatch,
		// Token: 0x0400016C RID: 364
		LpcReceiveBufferExpected,
		// Token: 0x0400016D RID: 365
		LpcInvalidConnectionUsage,
		// Token: 0x0400016E RID: 366
		LpcRequestsNotAllowed,
		// Token: 0x0400016F RID: 367
		ResourceInUse,
		// Token: 0x04000170 RID: 368
		ProcessIsProtected = 3221227282U,
		// Token: 0x04000171 RID: 369
		VolumeDirty = 3221227526U,
		// Token: 0x04000172 RID: 370
		FileCheckedOut = 3221227777U,
		// Token: 0x04000173 RID: 371
		CheckOutRequired,
		// Token: 0x04000174 RID: 372
		BadFileType,
		// Token: 0x04000175 RID: 373
		FileTooLarge,
		// Token: 0x04000176 RID: 374
		FormsAuthRequired,
		// Token: 0x04000177 RID: 375
		VirusInfected,
		// Token: 0x04000178 RID: 376
		VirusDeleted,
		// Token: 0x04000179 RID: 377
		TransactionalConflict = 3222863873U,
		// Token: 0x0400017A RID: 378
		InvalidTransaction,
		// Token: 0x0400017B RID: 379
		TransactionNotActive,
		// Token: 0x0400017C RID: 380
		TmInitializationFailed,
		// Token: 0x0400017D RID: 381
		RmNotActive,
		// Token: 0x0400017E RID: 382
		RmMetadataCorrupt,
		// Token: 0x0400017F RID: 383
		TransactionNotJoined,
		// Token: 0x04000180 RID: 384
		DirectoryNotRm,
		// Token: 0x04000181 RID: 385
		CouldNotResizeLog,
		// Token: 0x04000182 RID: 386
		TransactionsUnsupportedRemote,
		// Token: 0x04000183 RID: 387
		LogResizeInvalidSize,
		// Token: 0x04000184 RID: 388
		RemoteFileVersionMismatch,
		// Token: 0x04000185 RID: 389
		CrmProtocolAlreadyExists = 3222863887U,
		// Token: 0x04000186 RID: 390
		TransactionPropagationFailed,
		// Token: 0x04000187 RID: 391
		CrmProtocolNotFound,
		// Token: 0x04000188 RID: 392
		TransactionSuperiorExists,
		// Token: 0x04000189 RID: 393
		TransactionRequestNotValid,
		// Token: 0x0400018A RID: 394
		TransactionNotRequested,
		// Token: 0x0400018B RID: 395
		TransactionAlreadyAborted,
		// Token: 0x0400018C RID: 396
		TransactionAlreadyCommitted,
		// Token: 0x0400018D RID: 397
		TransactionInvalidMarshallBuffer,
		// Token: 0x0400018E RID: 398
		CurrentTransactionNotValid,
		// Token: 0x0400018F RID: 399
		LogGrowthFailed,
		// Token: 0x04000190 RID: 400
		ObjectNoLongerExists = 3222863905U,
		// Token: 0x04000191 RID: 401
		StreamMiniversionNotFound,
		// Token: 0x04000192 RID: 402
		StreamMiniversionNotValid,
		// Token: 0x04000193 RID: 403
		MiniversionInaccessibleFromSpecifiedTransaction,
		// Token: 0x04000194 RID: 404
		CantOpenMiniversionWithModifyIntent,
		// Token: 0x04000195 RID: 405
		CantCreateMoreStreamMiniversions,
		// Token: 0x04000196 RID: 406
		HandleNoLongerValid = 3222863912U,
		// Token: 0x04000197 RID: 407
		NoTxfMetadata,
		// Token: 0x04000198 RID: 408
		LogCorruptionDetected = 3222863920U,
		// Token: 0x04000199 RID: 409
		CantRecoverWithHandleOpen,
		// Token: 0x0400019A RID: 410
		RmDisconnected,
		// Token: 0x0400019B RID: 411
		EnlistmentNotSuperior,
		// Token: 0x0400019C RID: 412
		RecoveryNotNeeded,
		// Token: 0x0400019D RID: 413
		RmAlreadyStarted,
		// Token: 0x0400019E RID: 414
		FileIdentityNotPersistent,
		// Token: 0x0400019F RID: 415
		CantBreakTransactionalDependency,
		// Token: 0x040001A0 RID: 416
		CantCrossRmBoundary,
		// Token: 0x040001A1 RID: 417
		TxfDirNotEmpty,
		// Token: 0x040001A2 RID: 418
		IndoubtTransactionsExist,
		// Token: 0x040001A3 RID: 419
		TmVolatile,
		// Token: 0x040001A4 RID: 420
		RollbackTimerExpired,
		// Token: 0x040001A5 RID: 421
		TxfAttributeCorrupt,
		// Token: 0x040001A6 RID: 422
		EfsNotAllowedInTransaction,
		// Token: 0x040001A7 RID: 423
		TransactionalOpenNotAllowed,
		// Token: 0x040001A8 RID: 424
		TransactedMappingUnsupportedRemote,
		// Token: 0x040001A9 RID: 425
		TxfMetadataAlreadyPresent,
		// Token: 0x040001AA RID: 426
		TransactionScopeCallbacksNotSet,
		// Token: 0x040001AB RID: 427
		TransactionRequiredPromotion,
		// Token: 0x040001AC RID: 428
		CannotExecuteFileInTransaction,
		// Token: 0x040001AD RID: 429
		TransactionsNotFrozen,
		// Token: 0x040001AE RID: 430
		MaximumNtStatus = 4294967295U
	}
}
