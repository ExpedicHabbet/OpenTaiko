﻿using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using FDK;
using FDK.ExtensionMethods;

namespace OpenTaiko;

internal class CConfigIni : INotifyPropertyChanged {
	private const int MinimumKeyboardSoundLevelIncrement = 1;
	private const int MaximumKeyboardSoundLevelIncrement = 20;
	private const int DefaultKeyboardSoundLevelIncrement = 5;

	// Class

	#region [ CKeyAssign ]

	public class CKeyAssign {
		public class CKeyAssignPad {
			public CConfigIni.CKeyAssign.STKEYASSIGN[] HH {
				get { return this.padHH_R; }
				set { this.padHH_R = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] R {
				get { return this.padHH_R; }
				set { this.padHH_R = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] SD {
				get { return this.padSD_G; }
				set { this.padSD_G = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] G {
				get { return this.padSD_G; }
				set { this.padSD_G = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] BD {
				get { return this.padBD_B; }
				set { this.padBD_B = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] B {
				get { return this.padBD_B; }
				set { this.padBD_B = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] HT {
				get { return this.padHT_Pick; }
				set { this.padHT_Pick = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] Pick {
				get { return this.padHT_Pick; }
				set { this.padHT_Pick = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] LT {
				get { return this.padLT_Wail; }
				set { this.padLT_Wail = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] Wail {
				get { return this.padLT_Wail; }
				set { this.padLT_Wail = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] FT {
				get { return this.padFT_Cancel; }
				set { this.padFT_Cancel = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] Cancel {
				get { return this.padFT_Cancel; }
				set { this.padFT_Cancel = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] CY {
				get { return this.padCY_Decide; }
				set { this.padCY_Decide = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] Decide {
				get { return this.padCY_Decide; }
				set { this.padCY_Decide = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] HHO {
				get { return this.padHHO; }
				set { this.padHHO = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] RD {
				get { return this.padRD; }
				set { this.padRD = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] LC {
				get { return this.padLC; }
				set { this.padLC = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] LP {
				get { return this.padLP; }
				set { this.padLP = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] LBD {
				get { return this.padLBD; }
				set { this.padLBD = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] LeftRed {
				get { return this.padLRed; }
				set { this.padLRed = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] RightRed {
				get { return this.padRRed; }
				set { this.padRRed = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] LeftBlue {
				get { return this.padLBlue; }
				set { this.padLBlue = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] RightBlue {
				get { return this.padRBlue; }
				set { this.padRBlue = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] LeftRed2P {
				get { return this.padLRed2P; }
				set { this.padLRed2P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] RightRed2P {
				get { return this.padRRed2P; }
				set { this.padRRed2P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] LeftBlue2P {
				get { return this.padLBlue2P; }
				set { this.padLBlue2P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] RightBlue2P {
				get { return this.padRBlue2P; }
				set { this.padRBlue2P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] LeftRed3P {
				get { return this.padLRed3P; }
				set { this.padLRed3P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] RightRed3P {
				get { return this.padRRed3P; }
				set { this.padRRed3P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] LeftBlue3P {
				get { return this.padLBlue3P; }
				set { this.padLBlue3P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] RightBlue3P {
				get { return this.padRBlue3P; }
				set { this.padRBlue3P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] LeftRed4P {
				get { return this.padLRed4P; }
				set { this.padLRed4P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] RightRed4P {
				get { return this.padRRed4P; }
				set { this.padRRed4P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] LeftBlue4P {
				get { return this.padLBlue4P; }
				set { this.padLBlue4P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] RightBlue4P {
				get { return this.padRBlue4P; }
				set { this.padRBlue4P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] LeftRed5P {
				get { return this.padLRed5P; }
				set { this.padLRed5P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] RightRed5P {
				get { return this.padRRed5P; }
				set { this.padRRed5P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] LeftBlue5P {
				get { return this.padLBlue5P; }
				set { this.padLBlue5P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] RightBlue5P {
				get { return this.padRBlue5P; }
				set { this.padRBlue5P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] Clap {
				get { return this.padClap; }
				set { this.padClap = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] Clap2P {
				get { return this.padClap2P; }
				set { this.padClap2P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] Clap3P {
				get { return this.padClap3P; }
				set { this.padClap3P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] Clap4P {
				get { return this.padClap4P; }
				set { this.padClap4P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] Clap5P {
				get { return this.padClap5P; }
				set { this.padClap5P = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] LeftChange {
				get { return this.padLeftChange; }
				set { this.padLeftChange = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] RightChange {
				get { return this.padRightChange; }
				set { this.padRightChange = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] Capture {
				get { return this.padCapture; }
				set { this.padCapture = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] SongVolIncrease {
				get { return this.padSongVolIncrease; }
				set { this.padSongVolIncrease = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] SongVolDecrease {
				get { return this.padSongVolDecrease; }
				set { this.padSongVolDecrease = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] DisplayHits {
				get { return this.padDisplayHits; }
				set { this.padDisplayHits = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] DisplayDebug {
				get { return this.padDisplayDebug; }
				set { this.padDisplayDebug = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] QuickConfig {
				get { return this.padQuickConfig; }
				set { this.padQuickConfig = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] NewHeya {
				get { return this.padNewHeya; }
				set { this.padNewHeya = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] SortSongs {
				get { return this.padSortSongs; }
				set { this.padSortSongs = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] ToggleAutoP1 {
				get { return this.padToggleAutoP1; }
				set { this.padToggleAutoP1 = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] ToggleAutoP2 {
				get { return this.padToggleAutoP2; }
				set { this.padToggleAutoP2 = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] ToggleTrainingMode {
				get { return this.padToggleTrainingMode; }
				set { this.padToggleTrainingMode = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] CycleVideoDisplayMode {
				get { return this.padCycleVideoDisplayMode; }
				set { this.padCycleVideoDisplayMode = value; }
			}

			public CConfigIni.CKeyAssign.STKEYASSIGN[] this[int index] {
				get {
					switch (index) {
						case (int)EKeyConfigPad.HH:
							return this.padHH_R;

						case (int)EKeyConfigPad.SD:
							return this.padSD_G;

						case (int)EKeyConfigPad.BD:
							return this.padBD_B;

						case (int)EKeyConfigPad.HT:
							return this.padHT_Pick;

						case (int)EKeyConfigPad.LT:
							return this.padLT_Wail;

						case (int)EKeyConfigPad.FT:
							return this.padFT_Cancel;

						case (int)EKeyConfigPad.CY:
							return this.padCY_Decide;

						case (int)EKeyConfigPad.HHO:
							return this.padHHO;

						case (int)EKeyConfigPad.RD:
							return this.padRD;

						case (int)EKeyConfigPad.LC:
							return this.padLC;

						case (int)EKeyConfigPad.LP: // #27029 2012.1.4 from
							return this.padLP; //

						case (int)EKeyConfigPad.LBD: // #27029 2012.1.4 from
							return this.padLBD; //

						case (int)EKeyConfigPad.LRed:
							return this.padLRed;

						case (int)EKeyConfigPad.RRed:
							return this.padRRed;

						case (int)EKeyConfigPad.LBlue:
							return this.padLBlue;

						case (int)EKeyConfigPad.RBlue:
							return this.padRBlue;

						case (int)EKeyConfigPad.LRed2P:
							return this.padLRed2P;

						case (int)EKeyConfigPad.RRed2P:
							return this.padRRed2P;

						case (int)EKeyConfigPad.LBlue2P:
							return this.padLBlue2P;

						case (int)EKeyConfigPad.RBlue2P:
							return this.padRBlue2P;

						case (int)EKeyConfigPad.LRed3P:
							return this.padLRed3P;

						case (int)EKeyConfigPad.RRed3P:
							return this.padRRed3P;

						case (int)EKeyConfigPad.LBlue3P:
							return this.padLBlue3P;

						case (int)EKeyConfigPad.RBlue3P:
							return this.padRBlue3P;

						case (int)EKeyConfigPad.LRed4P:
							return this.padLRed4P;

						case (int)EKeyConfigPad.RRed4P:
							return this.padRRed4P;

						case (int)EKeyConfigPad.LBlue4P:
							return this.padLBlue4P;

						case (int)EKeyConfigPad.RBlue4P:
							return this.padRBlue4P;

						case (int)EKeyConfigPad.LRed5P:
							return this.padLRed5P;

						case (int)EKeyConfigPad.RRed5P:
							return this.padRRed5P;

						case (int)EKeyConfigPad.LBlue5P:
							return this.padLBlue5P;

						case (int)EKeyConfigPad.RBlue5P:
							return this.padRBlue5P;

						case (int)EKeyConfigPad.Clap:
							return this.padClap;

						case (int)EKeyConfigPad.Clap2P:
							return this.padClap2P;

						case (int)EKeyConfigPad.Clap3P:
							return this.padClap3P;

						case (int)EKeyConfigPad.Clap4P:
							return this.padClap4P;

						case (int)EKeyConfigPad.Clap5P:
							return this.padClap5P;

						case (int)EKeyConfigPad.LeftChange:
							return this.padLeftChange;

						case (int)EKeyConfigPad.RightChange:
							return this.padRightChange;

						case (int)EKeyConfigPad.Capture:
							return this.padCapture;

						case (int)EKeyConfigPad.SongVolumeIncrease:
							return this.padSongVolIncrease;

						case (int)EKeyConfigPad.SongVolumeDecrease:
							return this.padSongVolDecrease;

						case (int)EKeyConfigPad.DisplayHits:
							return this.padDisplayHits;

						case (int)EKeyConfigPad.DisplayDebug:
							return this.padDisplayDebug;

						case (int)EKeyConfigPad.QuickConfig:
							return this.padQuickConfig;

						case (int)EKeyConfigPad.NewHeya:
							return this.padNewHeya;

						case (int)EKeyConfigPad.SortSongs:
							return this.padSortSongs;

						case (int)EKeyConfigPad.ToggleAutoP1:
							return this.padToggleAutoP1;

						case (int)EKeyConfigPad.ToggleAutoP2:
							return this.padToggleAutoP2;

						case (int)EKeyConfigPad.ToggleTrainingMode:
							return this.padToggleTrainingMode;

						case (int)EKeyConfigPad.CycleVideoDisplayMode:
							return this.padCycleVideoDisplayMode;

						case (int)EKeyConfigPad.TrainingIncreaseScrollSpeed:
							return this.TrainingIncreaseScrollSpeed;

						case (int)EKeyConfigPad.TrainingIncreaseSongSpeed:
							return this.TrainingIncreaseSongSpeed;

						case (int)EKeyConfigPad.TrainingDecreaseSongSpeed:
							return this.TrainingDecreaseSongSpeed;

						case (int)EKeyConfigPad.TrainingDecreaseScrollSpeed:
							return this.TrainingDecreaseScrollSpeed;

						case (int)EKeyConfigPad.TrainingToggleAuto:
							return this.TrainingToggleAuto;

						case (int)EKeyConfigPad.TrainingBranchNormal:
							return this.TrainingBranchNormal;

						case (int)EKeyConfigPad.TrainingBranchExpert:
							return this.TrainingBranchExpert;

						case (int)EKeyConfigPad.TrainingBranchMaster:
							return this.TrainingBranchMaster;

						case (int)EKeyConfigPad.TrainingPause:
							return this.TrainingPause;

						case (int)EKeyConfigPad.TrainingBookmark:
							return this.TrainingBookmark;

						case (int)EKeyConfigPad.TrainingMoveForwardMeasure:
							return this.TrainingMoveForwardMeasure;

						case (int)EKeyConfigPad.TrainingMoveBackMeasure:
							return this.TrainingMoveBackMeasure;

						case (int)EKeyConfigPad.TrainingSkipForwardMeasure:
							return this.TrainingSkipForwardMeasure;

						case (int)EKeyConfigPad.TrainingSkipBackMeasure:
							return this.TrainingSkipBackMeasure;

						case (int)EKeyConfigPad.TrainingJumpToFirstMeasure:
							return this.TrainingJumpToFirstMeasure;

						case (int)EKeyConfigPad.TrainingJumpToLastMeasure:
							return this.TrainingJumpToLastMeasure;
					}

					throw new IndexOutOfRangeException();
				}
				set {
					switch (index) {
						case (int)EKeyConfigPad.HH:
							this.padHH_R = value;
							return;

						case (int)EKeyConfigPad.SD:
							this.padSD_G = value;
							return;

						case (int)EKeyConfigPad.BD:
							this.padBD_B = value;
							return;

						case (int)EKeyConfigPad.Pick:
							this.padHT_Pick = value;
							return;

						case (int)EKeyConfigPad.LT:
							this.padLT_Wail = value;
							return;

						case (int)EKeyConfigPad.FT:
							this.padFT_Cancel = value;
							return;

						case (int)EKeyConfigPad.CY:
							this.padCY_Decide = value;
							return;

						case (int)EKeyConfigPad.HHO:
							this.padHHO = value;
							return;

						case (int)EKeyConfigPad.RD:
							this.padRD = value;
							return;

						case (int)EKeyConfigPad.LC:
							this.padLC = value;
							return;

						case (int)EKeyConfigPad.LP:
							this.padLP = value;
							return;

						case (int)EKeyConfigPad.LBD:
							this.padLBD = value;
							return;

						case (int)EKeyConfigPad.LRed:
							this.padLRed = value;
							return;

						case (int)EKeyConfigPad.RRed:
							this.padRRed = value;
							return;

						case (int)EKeyConfigPad.LBlue:
							this.padLBlue = value;
							return;

						case (int)EKeyConfigPad.RBlue:
							this.padRBlue = value;
							return;

						case (int)EKeyConfigPad.LRed2P:
							this.padLRed2P = value;
							return;

						case (int)EKeyConfigPad.RRed2P:
							this.padRRed2P = value;
							return;

						case (int)EKeyConfigPad.LBlue2P:
							this.padLBlue2P = value;
							return;

						case (int)EKeyConfigPad.RBlue2P:
							this.padRBlue2P = value;
							return;

						case (int)EKeyConfigPad.LRed3P:
							this.padLRed3P = value;
							return;

						case (int)EKeyConfigPad.RRed3P:
							this.padRRed3P = value;
							return;

						case (int)EKeyConfigPad.LBlue3P:
							this.padLBlue3P = value;
							return;

						case (int)EKeyConfigPad.RBlue3P:
							this.padRBlue3P = value;
							return;

						case (int)EKeyConfigPad.LRed4P:
							this.padLRed4P = value;
							return;

						case (int)EKeyConfigPad.RRed4P:
							this.padRRed4P = value;
							return;

						case (int)EKeyConfigPad.LBlue4P:
							this.padLBlue4P = value;
							return;

						case (int)EKeyConfigPad.RBlue4P:
							this.padRBlue4P = value;
							return;

						case (int)EKeyConfigPad.LRed5P:
							this.padLRed5P = value;
							return;

						case (int)EKeyConfigPad.RRed5P:
							this.padRRed5P = value;
							return;

						case (int)EKeyConfigPad.LBlue5P:
							this.padLBlue5P = value;
							return;

						case (int)EKeyConfigPad.RBlue5P:
							this.padRBlue5P = value;
							return;

						case (int)EKeyConfigPad.Clap:
							this.padClap = value;
							return;

						case (int)EKeyConfigPad.Clap2P:
							this.padClap2P = value;
							return;

						case (int)EKeyConfigPad.Clap3P:
							this.padClap3P = value;
							return;

						case (int)EKeyConfigPad.Clap4P:
							this.padClap4P = value;
							return;

						case (int)EKeyConfigPad.Clap5P:
							this.padClap5P = value;
							return;

						case (int)EKeyConfigPad.LeftChange:
							this.padLeftChange = value;
							return;

						case (int)EKeyConfigPad.RightChange:
							this.padRightChange = value;
							return;

						case (int)EKeyConfigPad.Capture:
							this.padCapture = value;
							return;

						case (int)EKeyConfigPad.SongVolumeIncrease:
							this.padSongVolIncrease = value;
							return;

						case (int)EKeyConfigPad.SongVolumeDecrease:
							this.padSongVolDecrease = value;
							return;

						case (int)EKeyConfigPad.DisplayHits:
							this.padDisplayHits = value;
							return;

						case (int)EKeyConfigPad.DisplayDebug:
							this.padDisplayDebug = value;
							return;

						case (int)EKeyConfigPad.QuickConfig:
							this.padQuickConfig = value;
							return;

						case (int)EKeyConfigPad.NewHeya:
							this.padNewHeya = value;
							return;

						case (int)EKeyConfigPad.SortSongs:
							this.padSortSongs = value;
							return;

						case (int)EKeyConfigPad.ToggleAutoP1:
							this.padToggleAutoP1 = value;
							return;

						case (int)EKeyConfigPad.ToggleAutoP2:
							this.padToggleAutoP2 = value;
							return;

						case (int)EKeyConfigPad.ToggleTrainingMode:
							this.padToggleTrainingMode = value;
							return;

						case (int)EKeyConfigPad.CycleVideoDisplayMode:
							this.padCycleVideoDisplayMode = value;
							return;

						case (int)EKeyConfigPad.TrainingIncreaseScrollSpeed:
							this.TrainingIncreaseScrollSpeed = value;
							return;

						case (int)EKeyConfigPad.TrainingDecreaseScrollSpeed:
							this.TrainingDecreaseScrollSpeed = value;
							return;

						case (int)EKeyConfigPad.TrainingIncreaseSongSpeed:
							this.TrainingIncreaseSongSpeed = value;
							return;

						case (int)EKeyConfigPad.TrainingDecreaseSongSpeed:
							this.TrainingDecreaseSongSpeed = value;
							return;

						case (int)EKeyConfigPad.TrainingToggleAuto:
							this.TrainingToggleAuto = value;
							return;

						case (int)EKeyConfigPad.TrainingBranchNormal:
							this.TrainingBranchNormal = value;
							return;

						case (int)EKeyConfigPad.TrainingBranchExpert:
							this.TrainingBranchExpert = value;
							return;

						case (int)EKeyConfigPad.TrainingBranchMaster:
							this.TrainingBranchMaster = value;
							return;

						case (int)EKeyConfigPad.TrainingPause:
							this.TrainingPause = value;
							return;

						case (int)EKeyConfigPad.TrainingBookmark:
							this.TrainingBookmark = value;
							return;

						case (int)EKeyConfigPad.TrainingMoveForwardMeasure:
							this.TrainingMoveForwardMeasure = value;
							return;

						case (int)EKeyConfigPad.TrainingMoveBackMeasure:
							this.TrainingMoveBackMeasure = value;
							return;

						case (int)EKeyConfigPad.TrainingSkipForwardMeasure:
							this.TrainingSkipForwardMeasure = value;
							return;

						case (int)EKeyConfigPad.TrainingSkipBackMeasure:
							this.TrainingSkipBackMeasure = value;
							return;

						case (int)EKeyConfigPad.TrainingJumpToFirstMeasure:
							this.TrainingJumpToFirstMeasure = value;
							return;

						case (int)EKeyConfigPad.TrainingJumpToLastMeasure:
							this.TrainingJumpToLastMeasure = value;
							return;
					}

					throw new IndexOutOfRangeException();
				}
			}

			#region [ private ]

			//-----------------
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padBD_B;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padCY_Decide;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padFT_Cancel;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padHH_R;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padHHO;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padHT_Pick;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padLC;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padLT_Wail;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padRD;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padSD_G;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padLP;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padLBD;

			private CConfigIni.CKeyAssign.STKEYASSIGN[] padLRed;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padLBlue;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padRRed;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padRBlue;

			private CConfigIni.CKeyAssign.STKEYASSIGN[] padLRed2P;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padLBlue2P;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padRRed2P;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padRBlue2P;

			private CConfigIni.CKeyAssign.STKEYASSIGN[] padLRed3P;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padLBlue3P;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padRRed3P;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padRBlue3P;

			private CConfigIni.CKeyAssign.STKEYASSIGN[] padLRed4P;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padLBlue4P;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padRRed4P;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padRBlue4P;

			private CConfigIni.CKeyAssign.STKEYASSIGN[] padLRed5P;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padLBlue5P;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padRRed5P;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padRBlue5P;

			private CConfigIni.CKeyAssign.STKEYASSIGN[] padClap;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padClap2P;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padClap3P;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padClap4P;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padClap5P;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padLeftChange;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padRightChange;

			private CConfigIni.CKeyAssign.STKEYASSIGN[] padCapture;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padSongVolIncrease;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padSongVolDecrease;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padDisplayHits;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padDisplayDebug;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padQuickConfig;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padNewHeya;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padSortSongs;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padToggleAutoP1;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padToggleAutoP2;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padToggleTrainingMode;
			private CConfigIni.CKeyAssign.STKEYASSIGN[] padCycleVideoDisplayMode;

			public CConfigIni.CKeyAssign.STKEYASSIGN[] TrainingIncreaseScrollSpeed;
			public CConfigIni.CKeyAssign.STKEYASSIGN[] TrainingDecreaseScrollSpeed;
			public CConfigIni.CKeyAssign.STKEYASSIGN[] TrainingToggleAuto;
			public CConfigIni.CKeyAssign.STKEYASSIGN[] TrainingBranchNormal;
			public CConfigIni.CKeyAssign.STKEYASSIGN[] TrainingBranchExpert;
			public CConfigIni.CKeyAssign.STKEYASSIGN[] TrainingBranchMaster;
			public CConfigIni.CKeyAssign.STKEYASSIGN[] TrainingPause;
			public CConfigIni.CKeyAssign.STKEYASSIGN[] TrainingBookmark;
			public CConfigIni.CKeyAssign.STKEYASSIGN[] TrainingMoveForwardMeasure;
			public CConfigIni.CKeyAssign.STKEYASSIGN[] TrainingMoveBackMeasure;
			public CConfigIni.CKeyAssign.STKEYASSIGN[] TrainingSkipForwardMeasure;
			public CConfigIni.CKeyAssign.STKEYASSIGN[] TrainingSkipBackMeasure;
			public CConfigIni.CKeyAssign.STKEYASSIGN[] TrainingIncreaseSongSpeed;
			public CConfigIni.CKeyAssign.STKEYASSIGN[] TrainingDecreaseSongSpeed;
			public CConfigIni.CKeyAssign.STKEYASSIGN[] TrainingJumpToFirstMeasure;

			public CConfigIni.CKeyAssign.STKEYASSIGN[] TrainingJumpToLastMeasure;
			//-----------------

			#endregion
		}

		public bool KeyIsPressed(STKEYASSIGN[] pad) {
			if (OpenTaiko.InputManager == null) return false; // Input initialisation failed/not reached
			return OpenTaiko.InputManager.Keyboard.KeyPressed(pad.ToList().ConvertAll<int>(key => key.Code));
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct STKEYASSIGN {
			public EInputDevice InputDevice;
			public int ID;
			public int Code;

			public STKEYASSIGN(EInputDevice DeviceType, int nID, int nCode) {
				this.InputDevice = DeviceType;
				this.ID = nID;
				this.Code = nCode;
			}
		}

		public CKeyAssignPad Bass = new CKeyAssignPad();
		public CKeyAssignPad Drums = new CKeyAssignPad();
		public CKeyAssignPad Guitar = new CKeyAssignPad();
		public CKeyAssignPad Taiko = new CKeyAssignPad();
		public CKeyAssignPad System = new CKeyAssignPad();

		public CKeyAssignPad this[int index] {
			get {
				switch (index) {
					case (int)EKeyConfigPart.Drums:
						return this.Drums;

					case (int)EKeyConfigPart.Guitar:
						return this.Guitar;

					case (int)EKeyConfigPart.Bass:
						return this.Bass;

					case (int)EKeyConfigPart.Taiko:
						return this.Taiko;

					case (int)EKeyConfigPart.System:
						return this.System;
				}

				throw new IndexOutOfRangeException();
			}
			set {
				switch (index) {
					case (int)EKeyConfigPart.Drums:
						this.Drums = value;
						return;

					case (int)EKeyConfigPart.Guitar:
						this.Guitar = value;
						return;

					case (int)EKeyConfigPart.Bass:
						this.Bass = value;
						return;

					case (int)EKeyConfigPart.Taiko:
						this.Taiko = value;
						return;

					case (int)EKeyConfigPart.System:
						this.System = value;
						return;
				}

				throw new IndexOutOfRangeException();
			}
		}
	}

	#endregion

	//
	public enum ESoundDeviceTypeForConfig {
		Bass,
		ASIO,
		WASAPI_Exclusive,
		WASAPI_Shared,
		Unknown = 99
	}
	// Properties

	public class CAIPerformances {
		public int nGoodOdds;
		public int nPerfectOdds;
		public int nBadOdds;
		public int nRollSpeed;
		public int nMineHitOdds;

		public CAIPerformances(int po, int go, int bo, int rp, int mho = 0) {
			nGoodOdds = go;
			nPerfectOdds = po;
			nBadOdds = bo;
			nRollSpeed = rp;
			nMineHitOdds = mho;
		}
	}

	public class CTimingZones {
		public int nGoodZone;
		public int nOkZone;
		public int nBadZone;

		public CTimingZones(int gz, int oz, int bz) {
			nGoodZone = gz;
			nOkZone = oz;
			nBadZone = bz;
		}
	}

	public int nBGAlpha;
	public bool bEnableAVI;
	public bool bEnableBGA;
	public bool bBGMPlayVoiceSound;
	public bool bOutputDetailedDTXLog;
	public bool bOutputSongSearchLog;
	public bool bOutputCreationReleaseLog;
	public STDGBVALUE<bool> bReverse;

	public bool bDanTowerHide;

	public bool bTight;
	public bool bIncludeSubfoldersOnRandomSelect;
	public bool bOutputLogs;
	public bool bDisplayDebugInfo;
	public bool bEnableVSync;
	public bool bFullScreen;
	public bool bIgnoreSongUnlockables;
	public int nWindowBaseXPosition; // #30675 2013.02.04 ikanick add
	public int nWindowBaseYPosition;
	public int nWindowWidth; // #23510 2010.10.31 yyagi add
	public int nWindowHeight; // #23510 2010.10.31 yyagi add
	public Dictionary<int, string> dicJoystick;
	public Dictionary<int, string> dicGamepad;
	public ERandomMode[] eRandom;
	public CKeyAssign KeyAssign;
	public int nMsSleepUnfocused; // #23568 2010.11.04 ikanick add
	public int nMsSleepPerFrame; // #xxxxx 2011.11.27 yyagi add
	public int nSongSpeed;

	public double SongPlaybackSpeed {
		get => ((double)nSongSpeed) / 20.0;
	}

	public bool bNoAudioIfNot1xSpeed; // FIXME: Negation should be removed and booleans flipped
	public int nMsWaitPreviewSoundFromSongSelected;
	public int nMsWaitPreviewImageFromSongSelected;

	private bool _applyLoudnessMetadata;

	public bool ApplyLoudnessMetadata {
		get => _applyLoudnessMetadata;
		set => SetProperty(ref _applyLoudnessMetadata, value, nameof(ApplyLoudnessMetadata));
	}

	private double _targetLoudness;

	public double TargetLoudness {
		get => _targetLoudness;
		set => SetProperty(ref _targetLoudness, value, nameof(TargetLoudness));
	}

	private bool _applySongVol;

	public bool ApplySongVol {
		get => _applySongVol;
		set => SetProperty(ref _applySongVol, value, nameof(ApplySongVol));
	}

	private int _soundEffectLevel;

	public int SoundEffectLevel {
		get => _soundEffectLevel;
		set => SetProperty(ref _soundEffectLevel, value, nameof(SoundEffectLevel));
	}

	private int _voiceLevel;

	public int VoiceLevel {
		get => _voiceLevel;
		set => SetProperty(ref _voiceLevel, value, nameof(VoiceLevel));
	}

	private int _songPreviewLevel;

	public int SongPreviewLevel {
		get => _songPreviewLevel;
		set => SetProperty(ref _songPreviewLevel, value, nameof(SongPreviewLevel));
	}

	private int _songPlaybackLevel;

	public int SongPlaybackLevel {
		get => _songPlaybackLevel;
		set => SetProperty(ref _songPlaybackLevel, value, nameof(SongPlaybackLevel));
	}

	private int _keyboardSoundLevelIncrement;

	public int KeyboardSoundLevelIncrement {
		get => _keyboardSoundLevelIncrement;
		set => SetProperty(
			ref _keyboardSoundLevelIncrement,
			value.Clamp(MinimumKeyboardSoundLevelIncrement, MaximumKeyboardSoundLevelIncrement),
			nameof(KeyboardSoundLevelIncrement));
	}

	public STDGBVALUE<int> nMinDisplayedCombo;
	public int[] nScrollSpeed;
	public int[] nTimingZones;
	public EGameType[] nGameType;
	public EFunMods[] nFunMods;
	public string strSongsPath;
	public string FontName;
	public string BoxFontName;
	public bool bBranchGuide;
	public int nScoreMode;
	public int nDefaultCourse; //2017.01.30 DD デフォルトでカーソルをあわせる難易度

	private int _nPlayerCount;
	public int nPreviousPlayerCount = 1; // Specific usages

	public int nPlayerCount {
		get {
			if (bAIBattleMode) {
				return 2;
			} else {
				return _nPlayerCount;
			}
		}
		set { _nPlayerCount = value; }
	}

	public bool[] bAutoPlay = new bool[5];

	public bool bAuto先生の連打;
	public int nRollsPerSec;
	public int nDefaultAILevel = 4;
	public int nAILevel = 4;
	public bool bAIBattleMode = false;
	public int nControllerDeadzone = 50;

	public CAIPerformances[] apAIPerformances = {
		new CAIPerformances(500, 400, 100, 7, 200),
		new CAIPerformances(650, 310, 40, 8, 150),
		new CAIPerformances(750, 225, 25, 9, 100),
		new CAIPerformances(800, 180, 20, 10, 70),
		new CAIPerformances(850, 135, 15, 12, 50),
		new CAIPerformances(900, 90, 10, 14, 30),
		new CAIPerformances(920, 75, 5, 16, 20),
		new CAIPerformances(950, 49, 1, 22, 10),
		new CAIPerformances(975, 25, 0, 26, 5),
		new CAIPerformances(1000, 0, 0, 30, 0)
	};

	public CTimingZones[] tzLevels = {
		new CTimingZones(75, 108, 125), // Lv0 (Easy-Normal + "Loose" mod)
		new CTimingZones(58, 108, 125), // Lv1 (Easy-Normal + "Lenient" mod)
		new CTimingZones(42, 108, 125), // Lv2 (Easy-Normal / Tower Ama-kuchi or Hard-Extreme + "Loose" mod)
		new CTimingZones(42, 75, 108), // Lv3 (Hard-Extreme + "Lenient" timing mod or Easy-Normal + "Strict" mod)
		new CTimingZones(25, 75, 108), // Lv4 (Hard-Extreme / Tower Ex Kara-kuchi / Dan or Easy-Normal + "Rigorous" mod)
		new CTimingZones(25, 58, 108), // Lv5 (Hard-Extreme + "Strict" mod (Tatsu))
		new CTimingZones(17, 42, 108) // Lv6 (Hard-Extreme + "Rigorous" mod)
	};

	public bool bJudgeBigNotes;
	public bool bForceNormalGauge;
	public int nBigNoteWaitTimems;
	public int nBranchAnime;

	// I18N choosen language
	public string sLang;

	// Song select screen layout type
	public int nLayoutType;

	public bool bJudgeCountDisplay;

	public bool ShowExExtraAnime;

	public bool bEnableCountdownTimer;

	// Display/Hide settings for each image
	public bool ShowChara;
	public bool ShowDancer;
	public bool ShowRunner;
	public bool ShowFooter;
	public bool ShowMob;
	public bool ShowPuchiChara; // リザーブ

	public bool bHispeedRandom;
	public EStealthMode[] eSTEALTH;
	public bool bNoInfo;

	public int nDefaultSongSort;
	public int nRecentlyPlayedMax;
	public EGame eGameMode;
	public int TokkunSkipMeasures;
	public int TokkunMashInterval;
	public bool bSuperHard = false;
	public bool bTokkunMode = false;
	public int[] bJust = new int[5] { 0, 0, 0, 0, 0 };

	public int[] nHitSounds = new int[5] { 0, 0, 0, 0, 0 };

	public int[][] nPanning = new int[5][] {
		new int[1] { 0 },
		new int[2] { -100, 100 },
		new int[3] { -100, 0, 100 },
		new int[4] { -100, -33, 33, 100 },
		new int[5] { -100, -50, 0, 50, 100 },
	};

	public string[] sSaveFile = new string[5] { "1P", "2P", "3P", "4P", "5P" };

	public bool bEndingAnime = false; // 2017.01.27 DD 「また遊んでね」画面の有効/無効オプション追加

	public STDGBVALUE<EJudgeTextDisplayPosition> JudgeTextDisplayPosition;
	public int nInputAdjustTimeMs;
	public int nGlobalOffsetMs;
	public bool bIsAutoResultCapture; // #25399 2011.6.9 yyagi リザルト画像自動保存機能のON/OFF制御
	public int nPoliphonicSounds; // #28228 2012.5.1 yyagi レーン毎の最大同時発音数
	public bool bBufferedInputs;
	public bool bIsEnabledSystemMenu; // #28200 2012.5.1 yyagi System Menuの使用可否切替
	public string strSystemSkinSubfolderFullName; // #28195 2012.5.2 yyagi Skin切替用 System/以下のサブフォルダ名

	public void tInitializeAILevel() {
		this.nAILevel = this.nDefaultAILevel;
	}

	public bool bEnterIsNotUsedInKeyAssignments {
		get {
			for (int i = 0; i <= (int)EKeyConfigPart.System; i++) {
				for (int j = 0; j < (int)EKeyConfigPad.Max; j++) {
					for (int k = 0; k < 0x10; k++) {
						if ((this.KeyAssign[i][j][k].InputDevice == EInputDevice.Keyboard) &&
							(this.KeyAssign[i][j][k].Code == (int)SlimDXKeys.Key.Return)) {
							return false;
						}
					}
				}
			}

			return true;
		}
	}

	public bool bWindowMode {
		get { return !this.bFullScreen; }
		set { this.bFullScreen = !value; }
	}

	public bool bDoNotDisplayPerformanceInfos {
		// FIXME: should be flipped
		get { return !this.bDisplayDebugInfo; }
		set { this.bDisplayDebugInfo = !value; }
	}

	public int nBackgroundTransparency {
		get { return this.nBGAlpha; }
		set {
			if (value < 0) {
				this.nBGAlpha = 0;
			} else if (value > 0xff) {
				this.nBGAlpha = 0xff;
			} else {
				this.nBGAlpha = value;
			}
		}
	}

	public int nGraphicsDeviceType;
	public int nRisky; // #23559 2011.6.20 yyagi Riskyでの残ミス数。0で閉店
	public bool bIsAllowedDoubleClickFullscreen; // #26752 2011.11.27 yyagi ダブルクリックしてもフルスクリーンに移行しない

	public int
		nSoundDeviceType; // #24820 2012.12.23 yyagi 出力サウンドデバイス(0=ACM(にしたいが設計がきつそうならDirectShow), 1=ASIO, 2=WASAPI)

	public int nBassBufferSizeMs; // #24820 2013.1.15 yyagi WASAPIのバッファサイズ

	public int nWASAPIBufferSizeMs; // #24820 2013.1.15 yyagi WASAPIのバッファサイズ

	//		public int nASIOBufferSizeMs;				// #24820 2012.12.28 yyagi ASIOのバッファサイズ
	public int nASIODevice; // #24820 2013.1.17 yyagi ASIOデバイス
	public bool bUseOSTimer; // #33689 2014.6.6 yyagi 演奏タイマーの種類
	public bool bDynamicBassMixerManagement; // #24820
	public bool bTimeStretch; // #23664 2013.2.24 yyagi ピッチ変更無しで再生速度を変更するかどうか
	public STDGBVALUE<EInvisible> eInvisible; // #32072 2013.9.20 yyagi チップを非表示にする
	public int nDisplayTimesMs, nFadeoutTimeMs;

	public STDGBVALUE<int> nViewerScrollSpeed;
	public bool bViewerVSyncWait;
	public bool bViewerShowDebugStatus;
	public bool bViewerTimeStretch;
	public bool bViewerDrums有効, bViewerGuitar有効;
	public int nMasterVolume;
	public bool ShinuchiMode; // 真打モード
	public bool FastRender; // 事前画像描画モード
	public bool ASyncTextureLoad; // 事前画像描画モード
	public bool PreAssetsLoading; // 事前画像描画モード
	public bool SimpleMode; // 事前画像描画モード
	public int MusicPreTimeMs; // 音源再生前の待機時間ms
	public const int MusicPreTimeMsOffset = 1500; // Added to the MusicPreTimeMs config for the final interpreted value

	public bool TJAP3FolderMode { get; private set; }


	/// <summary>
	/// DiscordのRitch Presenceに再生中の.tjaファイルの情報を送信するかどうか。
	/// </summary>
	public bool SendDiscordPlayingInformation;

	#region [ STRANGE ]

	public STRANGE nHitRangeMs;

	[StructLayout(LayoutKind.Sequential)]
	public struct STRANGE {
		public int Perfect;
		public int Great;
		public int Good;
		public int Poor;

		public int this[int index] {
			get {
				switch (index) {
					case 0:
						return this.Perfect;

					case 1:
						return this.Great;

					case 2:
						return this.Good;

					case 3:
						return this.Poor;
				}

				throw new IndexOutOfRangeException();
			}
			set {
				switch (index) {
					case 0:
						this.Perfect = value;
						return;

					case 1:
						this.Great = value;
						return;

					case 2:
						this.Good = value;
						return;

					case 3:
						this.Poor = value;
						return;
				}

				throw new IndexOutOfRangeException();
			}
		}
	}

	#endregion

	#region [ STLANEVALUE ]

	public STLANEVALUE nVelocityMin;

	[StructLayout(LayoutKind.Sequential)]
	public struct STLANEVALUE {
		public int LC;
		public int HH;
		public int SD;
		public int BD;
		public int HT;
		public int LT;
		public int FT;
		public int CY;
		public int RD;
		public int LP;
		public int LBD;
		public int Guitar;
		public int Bass;

		public int this[int index] {
			get {
				switch (index) {
					case 0:
						return this.LC;

					case 1:
						return this.HH;

					case 2:
						return this.SD;

					case 3:
						return this.BD;

					case 4:
						return this.HT;

					case 5:
						return this.LT;

					case 6:
						return this.FT;

					case 7:
						return this.CY;

					case 8:
						return this.RD;

					case 9:
						return this.LP;

					case 10:
						return this.LBD;

					case 11:
						return this.Guitar;

					case 12:
						return this.Bass;
				}

				throw new IndexOutOfRangeException();
			}
			set {
				switch (index) {
					case 0:
						this.LC = value;
						return;

					case 1:
						this.HH = value;
						return;

					case 2:
						this.SD = value;
						return;

					case 3:
						this.BD = value;
						return;

					case 4:
						this.HT = value;
						return;

					case 5:
						this.LT = value;
						return;

					case 6:
						this.FT = value;
						return;

					case 7:
						this.CY = value;
						return;

					case 8:
						this.RD = value;
						return;

					case 9:
						this.LP = value;
						return;

					case 10:
						this.LBD = value;
						return;

					case 11:
						this.Guitar = value;
						return;

					case 12:
						this.Bass = value;
						return;
				}

				throw new IndexOutOfRangeException();
			}
		}
	}

	#endregion


	#region[Ver.K追加オプション]

	//--------------------------
	//ゲーム内のオプションに加えて、
	//システム周りのオプションもこのブロックで記述している。

	#region[Display]

	//--------------------------
	public EClipDispType eClipDispType;

	#endregion

	#region[Position]

	public ELaneType eLaneType;
	public EMirror eMirror;

	#endregion

	#region[System]

	public bool bDirectShowMode;

	#endregion

	#region[DEBUG]

	public bool DEBUG_bShowImgui;

	#endregion

	//--------------------------

	#endregion


	// Constructor

	public CConfigIni() {
		this.strSongsPath = "Songs" + Path.DirectorySeparatorChar;
		this.bFullScreen = false;
		this.bIgnoreSongUnlockables = false;
		this.bEnableVSync = true;
		this.nWindowBaseXPosition = 100; // #30675 2013.02.04 ikanick add
		this.nWindowBaseYPosition = 100;
		this.nWindowWidth = GameWindowSize.Width; // #23510 2010.10.31 yyagi add
		this.nWindowHeight = GameWindowSize.Height; //
		this.nMsSleepPerFrame = -1; // #xxxxx 2011.11.27 yyagi add
		this.nMsSleepUnfocused = 1; // #23568 2010.11.04 ikanick add
		this._bGuitarEnabled = true;
		this._bDrumsEnabled = true;
		this.nBGAlpha = 100;
		this.bEnableAVI = false;
		this.eClipDispType = EClipDispType.BackgroundOnly;
		this.bEnableBGA = true;
		this.nMsWaitPreviewSoundFromSongSelected = 1000;
		this.nMsWaitPreviewImageFromSongSelected = 100;
		this.bBGMPlayVoiceSound = true;

		this.bDanTowerHide = false;

		this.bIncludeSubfoldersOnRandomSelect = true;
		this.nMinDisplayedCombo = new STDGBVALUE<int>();
		this.nMinDisplayedCombo.Drums = 10;
		this.nRollsPerSec = 15;
		this.nAILevel = 1;
		this.bAIBattleMode = false;

		this.FontName = CFontRenderer.DefaultFontName;
		this.BoxFontName = CFontRenderer.DefaultFontName;
		this.ApplyLoudnessMetadata = true;
		this.bEnableCountdownTimer = true;
		this.sLang = "en";
		this.nLayoutType = 1;

		// 2018-08-28 twopointzero:
		// There exists a particular large, well-known, well-curated, and
		// regularly-updated collection of content for use with simulators.
		// A statistical analysis was performed on the the integrated loudness
		// and true peak loudness of the thousands of songs within this
		// collection as of late August 2018.
		//
		// The analysis allows us to select a target loudness which
		// results in the smallest total amount of loudness adjustment
		// applied to the songs of that collection. The selected target
		// loudness should result in the least-noticeable average
		// adjustment for the most users, assuming their collection is
		// similar to the exemplar.
		//
		// The target loudness which achieves this is -7.4 LUFS.
		this.TargetLoudness = -7.4;

		this.ApplySongVol = false;
		this.SoundEffectLevel = CSound.DefaultSoundEffectLevel;
		this.VoiceLevel = CSound.DefaultVoiceLevel;
		this.SongPreviewLevel = CSound.DefaultSongPreviewLevel;
		this.SongPlaybackLevel = CSound.DefaultSongPlaybackLevel;
		this.KeyboardSoundLevelIncrement = DefaultKeyboardSoundLevelIncrement;
		this.bOutputLogs = true;
		this.bReverse = new STDGBVALUE<bool>();
		this.eRandom = new ERandomMode[5];
		this.JudgeTextDisplayPosition = new STDGBVALUE<EJudgeTextDisplayPosition>();
		this.nScrollSpeed = new int[5] { 9, 9, 9, 9, 9 };
		this.nTimingZones = new int[5] { 2, 2, 2, 2, 2 };
		this.nGameType = new EGameType[5] {
			EGameType.Taiko, EGameType.Taiko, EGameType.Taiko, EGameType.Taiko, EGameType.Taiko
		};
		this.nFunMods =
			new EFunMods[5] { EFunMods.None, EFunMods.None, EFunMods.None, EFunMods.None, EFunMods.None };
		this.nInputAdjustTimeMs = 0;
		this.nGlobalOffsetMs = 0;
		for (int i = 0; i < 3; i++) {
			this.bReverse[i] = false;
			this.JudgeTextDisplayPosition[i] = EJudgeTextDisplayPosition.AboveLane;
		}


		for (int i = 0; i < 5; i++) {
			this.eRandom[i] = ERandomMode.Off;
			this.nScrollSpeed[i] = 9;
			this.nTimingZones[i] = 2;
		}

		this.nSongSpeed = 20;
		this.bNoAudioIfNot1xSpeed = false;

		#region [ AutoPlay ]

		for (int i = 0; i < 5; i++) {
			this.bAutoPlay[i] = false;
		}

		this.bAuto先生の連打 = true;

		#endregion

		this.nHitRangeMs = new STRANGE();
		this.nHitRangeMs.Perfect = 25;
		this.nHitRangeMs.Great = -1; //使用しません。
		this.nHitRangeMs.Good = 75;
		this.nHitRangeMs.Poor = 108;
		this.ConfigIniFileName = "";
		this.dicJoystick = new Dictionary<int, string>(10);
		this.dicGamepad = new Dictionary<int, string>(10);

		this.sectionProcess = new Dictionary<ESectionType, Action<string, string>>() {
			{ ESectionType.System, this.ProcessSystemSection },
			{ ESectionType.AutoPlay, this.ProcessAutoPlaySection },
			{ ESectionType.HitRange, this.ProcessHitRangeSection },
			{ ESectionType.Log, this.ProcessLogSection },
			{ ESectionType.PlayOption, this.ProcessPlayOptionSection },
			{ ESectionType.ViewerOption, this.ProcessViewerOptionSection },
			{ ESectionType.GUID, this.ProcessGuidSection },
			{ ESectionType.DrumsKeyAssign, this.ProcessDrumKeyAssignmentSection },
			{ ESectionType.SystemKeyAssign, this.ProcessSystemKeyAssignmentSection },
			{ ESectionType.TrainingKeyAssign, this.ProcessTrainingKeyAssignmentSection },
			{ ESectionType.DEBUG, this.ProcessDebugSection },
		};

		this.SetDefaultKeyAssignments();

		#region [ velocityMin ]

		this.nVelocityMin.LC = 0; // #23857 2011.1.31 yyagi VelocityMin
		this.nVelocityMin.HH = 20;
		this.nVelocityMin.SD = 0;
		this.nVelocityMin.BD = 0;
		this.nVelocityMin.HT = 0;
		this.nVelocityMin.LT = 0;
		this.nVelocityMin.FT = 0;
		this.nVelocityMin.CY = 0;
		this.nVelocityMin.RD = 0;
		this.nVelocityMin.LP = 0;
		this.nVelocityMin.LBD = 0;

		#endregion

		this.nRisky = 0; // #23539 2011.7.26 yyagi RISKYモード
		this.bIsAutoResultCapture = false; // #25399 2011.6.9 yyagi リザルト画像自動保存機能ON/OFF

		this.bBufferedInputs = true;
		this.bIsAllowedDoubleClickFullscreen = false; // #26752 2011.11.26 ダブルクリックでのフルスクリーンモード移行を許可
		this.nPoliphonicSounds = 4; // #28228 2012.5.1 yyagi レーン毎の最大同時発音数
									// #24820 2013.1.15 yyagi 初期値を4から2に変更。BASS.net使用時の負荷軽減のため。
									// #24820 2013.1.17 yyagi 初期値を4に戻した。動的なミキサー制御がうまく動作しているため。
		this.bIsEnabledSystemMenu = true; // #28200 2012.5.1 yyagi System Menuの利用可否切替(使用可)
		this.strSystemSkinSubfolderFullName = ""; // #28195 2012.5.2 yyagi 使用中のSkinサブフォルダ名
		this.bTight = false; // #29500 2012.9.11 kairera0467 TIGHTモード
		nGraphicsDeviceType = 0;

		#region [ WASAPI/ASIO ]

		// #24820 2012.12.23 yyagi 初期値はACM | #31927 2013.8.25 yyagi OSにより初期値変更
		this.nSoundDeviceType = OperatingSystem.IsWindows()
			? (int)ESoundDeviceTypeForConfig.WASAPI_Shared
			: (int)ESoundDeviceTypeForConfig.Bass;
		nBassBufferSizeMs = 1;
		this.nWASAPIBufferSizeMs = 50; // #24820 2013.1.15 yyagi 初期値は50(0で自動設定)
		this.nASIODevice = 0; // #24820 2013.1.17 yyagi
							  //			this.nASIOBufferSizeMs = 0;					// #24820 2012.12.25 yyagi 初期値は0(自動設定)

		#endregion

		// #33689 2014.6.6 yyagi 初期値はfalse (FDKのタイマー。ＦＲＯＭ氏考案の独自タイマー) // 2024.4.27 DRT Gonna keep this on by default. Seems to cause more issues when off.
		this.bUseOSTimer = true;
		this.bDynamicBassMixerManagement = true; //
		this.bTimeStretch = false; // #23664 2013.2.24 yyagi 初期値はfalse (再生速度変更を、ピッチ変更にて行う)
		this.nDisplayTimesMs = 3000; // #32072 2013.10.24 yyagi Semi-Invisibleでの、チップ再表示期間
		this.nFadeoutTimeMs = 2000; // #32072 2013.10.24 yyagi Semi-Invisibleでの、チップフェードアウト時間

		bViewerVSyncWait = true;
		bViewerShowDebugStatus = true;
		bViewerTimeStretch = false;
		bViewerDrums有効 = true;
		bViewerGuitar有効 = true;


		this.bBranchGuide = false;
		this.nScoreMode = 2;
		this.nDefaultCourse = (int)Difficulty.Normal;
		this.nBranchAnime = 1;

		this.bJudgeBigNotes = false;
		bForceNormalGauge = false;
		this.nBigNoteWaitTimems = 50;

		this.bJudgeCountDisplay = false;

		ShowExExtraAnime = true;

		ShowChara = true;
		ShowDancer = true;
		ShowRunner = true;
		ShowFooter = true;
		ShowMob = true;
		ShowPuchiChara = true;

		this.eSTEALTH = new EStealthMode[5];

		for (int i = 0; i < 5; i++)
			this.eSTEALTH[i] = EStealthMode.Off;

		this.bNoInfo = false;

		//this.bNoMP3Streaming = false;
		this.nMasterVolume = 100; // #33700 2014.4.26 yyagi マスターボリュームの設定(WASAPI/ASIO用)
		this.bHispeedRandom = false;
		this.nDefaultSongSort = 2;
		this.nRecentlyPlayedMax = 5;
		this.eGameMode = EGame.Off;
		this.TokkunMashInterval = 750;
		this.bEndingAnime = false;
		this.nPlayerCount = 1; //2017.08.18 kairera0467 マルチプレイ対応
		ShinuchiMode = true; // Enable gen-4 score by default
		TJAP3FolderMode = false;
		FastRender = true;
		ASyncTextureLoad = true;
		PreAssetsLoading = true;
		SimpleMode = false;
		MusicPreTimeMs = 2500; // 2.5 seconds
		SendDiscordPlayingInformation = true;

		#region[ Ver.K追加 ]

		this.eLaneType = ELaneType.TypeA;
		this.bDirectShowMode = false;

		#endregion

		#region[DEBUG]

		DEBUG_bShowImgui = true;

		#endregion
	}

	public CConfigIni(string iniファイル名)
		: this() {
		this.LoadFromFile(iniファイル名);
	}


	// メソッド

	public void RemoveDuplicateKeyAssignments(EInputDevice deviceType, int nID, int nCode, EKeyConfigPad pad) {
		bool isMenu = pad is EKeyConfigPad.Decide or EKeyConfigPad.RightChange or EKeyConfigPad.LeftChange;
		for (int i = 0; i <= (int)EKeyConfigPart.System; i++) {
			// Do not restrict duplicate keybinds for System controls
			for (int j = 0; j < (int)EKeyConfigPad.Capture; j++) {
				bool isJMenu = j is (int)EKeyConfigPad.LeftChange
					or (int)EKeyConfigPad.RightChange
					or (int)EKeyConfigPad.Decide;
				if (isMenu != isJMenu) {
					continue;
				}
				for (int k = 0; k < 0x10; k++) {
					if (this.KeyAssign[i][j][k].InputDevice != deviceType ||
						this.KeyAssign[i][j][k].ID != nID ||
						this.KeyAssign[i][j][k].Code != nCode) {
						continue;
					}

					for (int m = k; m < 15; m++) {
						this.KeyAssign[i][j][m] = this.KeyAssign[i][j][m + 1];
					}

					this.KeyAssign[i][j][15].InputDevice = EInputDevice.Unknown;
					this.KeyAssign[i][j][15].ID = 0;
					this.KeyAssign[i][j][15].Code = 0;
					k--;
				}
			}
		}
	}

	public void t書き出し(string iniファイル名) {
		StreamWriter sw = new StreamWriter(iniファイル名, false, Encoding.GetEncoding(OpenTaiko.sEncType));
		sw.WriteLine(";-------------------");

		#region [ System ]

		sw.WriteLine("[System]");
		sw.WriteLine();

		#region [ Version ]

		sw.WriteLine("; リリースバージョン");
		sw.WriteLine("; Release Version.");
		sw.WriteLine("Version={0}", OpenTaiko.VERSION);
		sw.WriteLine();

		#endregion

		#region [ TJAPath ]

		sw.WriteLine("; 譜面ファイルが格納されているフォルダへのパス。");
		sw.WriteLine(@"; セミコロン(;)で区切ることにより複数のパスを指定できます。（例: d:\tja\;e:\tja2\）");
		sw.WriteLine("; Pathes for TJA data.");
		sw.WriteLine(@"; You can specify many pathes separated with semicolon(;). (e.g. d:\tja\;e:\tja2\)");
		sw.WriteLine("TJAPath={0}", this.strSongsPath);
		sw.WriteLine();

		#endregion

		#region [ スキン関連 ]

		#region [ Skinパスの絶対パス→相対パス変換 ]

		Uri uriRoot = new Uri(System.IO.Path.Combine(OpenTaiko.strEXEのあるフォルダ,
			"System" + System.IO.Path.DirectorySeparatorChar));
		if (strSystemSkinSubfolderFullName != null && strSystemSkinSubfolderFullName.Length == 0) {
			// Config.iniが空の状態でDTXManiaをViewerとして起動_終了すると、strSystemSkinSubfolderFullName が空の状態でここに来る。
			// → 初期値として Default/ を設定する。
			strSystemSkinSubfolderFullName = System.IO.Path.Combine(OpenTaiko.strEXEのあるフォルダ,
				"System" + System.IO.Path.DirectorySeparatorChar + "Default" +
				System.IO.Path.DirectorySeparatorChar);
		}

		Uri uriPath = new Uri(System.IO.Path.Combine(this.strSystemSkinSubfolderFullName,
			"." + System.IO.Path.DirectorySeparatorChar));
		string relPath = uriRoot.MakeRelativeUri(uriPath).ToString(); // 相対パスを取得
		relPath = System.Web.HttpUtility.UrlDecode(relPath); // デコードする
		relPath = relPath.Replace('/', System.IO.Path.DirectorySeparatorChar); // 区切り文字が\ではなく/なので置換する

		#endregion

		sw.WriteLine("; 使用するSkinのフォルダ名。");
		sw.WriteLine("; 例えば System/Default/Graphics/... などの場合は、SkinPath=./Default/ を指定します。");
		sw.WriteLine("; Skin folder path.");
		sw.WriteLine("; e.g. System/Default/Graphics/... -> Set SkinPath=./Default/");
		sw.WriteLine("SkinPath={0}", relPath);
		sw.WriteLine();
		sw.WriteLine("; 事前画像読み込み機能を使うかどうか。(0: OFF, 1: ON)");
		sw.WriteLine("; Use pre-textures load.");
		sw.WriteLine("{0}={1}", nameof(PreAssetsLoading), PreAssetsLoading ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; 事前画像描画機能を使うかどうか。(0: OFF, 1: ON)");
		sw.WriteLine("; Use pre-textures render.");
		sw.WriteLine("{0}={1}", nameof(FastRender), FastRender ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; 非同期画像読み込みを行うかどうか。(0: OFF, 1: ON)");
		sw.WriteLine("; Use pre-textures render.");
		sw.WriteLine("{0}={1}", nameof(ASyncTextureLoad), ASyncTextureLoad ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; シンプルモードを使うかどうか。(0: OFF, 1: ON)");
		sw.WriteLine("; Use simplemode");
		sw.WriteLine("{0}={1}", nameof(SimpleMode), SimpleMode ? 1 : 0);
		sw.WriteLine();

		#endregion


		#region [Language]

		sw.WriteLine("; プレイ中やメニューの表示される言語を変更。");
		sw.WriteLine("; Change the displayed language ingame and within the menus.");
		sw.WriteLine("Lang={0}", this.sLang);
		sw.WriteLine();

		#endregion

		#region [Layout Type]

		//this.nLayoutType

		sw.WriteLine("; Change the song select screen layout type.");
		sw.WriteLine("LayoutType={0}", this.nLayoutType);
		sw.WriteLine();

		#endregion

		#region [Save Files]

		sw.WriteLine("; File paths on the Saves folder.");
		sw.WriteLine("SaveFileName={0}", String.Join(",", this.sSaveFile));
		sw.WriteLine();
		sw.WriteLine("; Ignore song unlockables (0: No, 1: Yes)");
		sw.WriteLine("IgnoreSongUnlockables={0}", this.bIgnoreSongUnlockables ? 1 : 0);
		sw.WriteLine();

		#endregion

		#region [ Window関連 ]

		//sw.WriteLine("; 使用する描画API(0=OpenGL, 1=DirectX9, 2=DirectX11, 3=Vulkan, 4=Metal)");
		sw.WriteLine("; 使用する描画API(0=OpenGL, 1=DirectX11, 2=Vulkan, 3=Metal)");
		sw.WriteLine("GraphicsDeviceType={0}", (int)this.nGraphicsDeviceType);
		sw.WriteLine();
		sw.WriteLine("; 画面モード(0:ウィンドウ, 1:全画面)");
		sw.WriteLine("; Screen mode. (0:Window, 1:Fullscreen)");
		sw.WriteLine("FullScreen={0}", this.bFullScreen ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; ウインドウモード時の画面幅"); // #23510 2010.10.31 yyagi add
		sw.WriteLine("; A width size in the window mode."); //
		sw.WriteLine("WindowWidth={0}", this.nWindowWidth); //
		sw.WriteLine(); //
		sw.WriteLine("; ウインドウモード時の画面高さ"); //
		sw.WriteLine("; A height size in the window mode."); //
		sw.WriteLine("WindowHeight={0}", this.nWindowHeight); //
		sw.WriteLine(); //
		sw.WriteLine("; ウィンドウモード時の位置X"); // #30675 2013.02.04 ikanick add
		sw.WriteLine("; X position in the window mode."); //
		sw.WriteLine("WindowX={0}", this.nWindowBaseXPosition); //
		sw.WriteLine(); //
		sw.WriteLine("; ウィンドウモード時の位置Y"); //
		sw.WriteLine("; Y position in the window mode."); //
		sw.WriteLine("WindowY={0}", this.nWindowBaseYPosition); //
		sw.WriteLine(); //

		sw.WriteLine("; ウインドウをダブルクリックした時にフルスクリーンに移行するか(0:移行しない,1:移行する)"); // #26752 2011.11.27 yyagi
		sw.WriteLine("; Whether double click to go full screen mode or not.(0:No, 1:Yes)"); //
		sw.WriteLine("DoubleClickFullScreen={0}", this.bIsAllowedDoubleClickFullscreen ? 1 : 0); //
		sw.WriteLine(); //
		sw.WriteLine("; ALT+SPACEのメニュー表示を抑制するかどうか(0:抑制する 1:抑制しない)"); // #28200 2012.5.1 yyagi
		sw.WriteLine("; Whether ALT+SPACE menu would be masked or not.(0=masked 1=not masked)"); //
		sw.WriteLine("EnableSystemMenu={0}", this.bIsEnabledSystemMenu ? 1 : 0); //
		sw.WriteLine(); //
		sw.WriteLine("; 非フォーカス時のsleep値[ms]"); // #23568 2011.11.04 ikanick add
		sw.WriteLine("; A sleep time[ms] while the window is inactive."); //
		sw.WriteLine("BackSleep={0}", this.nMsSleepUnfocused); // そのまま引用（苦笑）
		sw.WriteLine(); //

		#endregion

		#region [ フォント ]

		sw.WriteLine("; フォントレンダリングに使用するフォント名");
		sw.WriteLine("; Font name used for font rendering.");
		sw.WriteLine("FontName={0}", this.FontName);
		sw.WriteLine();
		sw.WriteLine("; Boxの説明文のフォントレンダリングに使用するフォント名");
		sw.WriteLine("; Font name used for font rendering.");
		sw.WriteLine("BoxFontName={0}", this.BoxFontName);
		sw.WriteLine();

		#endregion

		#region [ フレーム処理関連(VSync, フレーム毎のsleep) ]

		sw.WriteLine("; 垂直帰線同期(0:OFF,1:ON)");
		sw.WriteLine("VSyncWait={0}", this.bEnableVSync ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; フレーム毎のsleep値[ms] (-1でスリープ無し, 0以上で毎フレームスリープ。動画キャプチャ等で活用下さい)"); // #xxxxx 2011.11.27 yyagi add
		sw.WriteLine("; A sleep time[ms] per frame."); //
		sw.WriteLine("SleepTimePerFrame={0}", this.nMsSleepPerFrame); //
		sw.WriteLine(); //

		#endregion

		#region [ WASAPI/ASIO関連 ]

		sw.WriteLine("; サウンド出力方式(0=ASIO, 1=WASAPI Exclusive, 2=WASAPI Shared)");
		sw.WriteLine("; WASAPIはVista以降のOSで使用可能。推奨方式はWASAPI。");
		sw.WriteLine("; なお、WASAPIが使用不可ならASIOを、ASIOが使用不可ならACMを使用します。");
		sw.WriteLine("; Sound device type(0=ASIO, 1=WASAPI Exclusive, 2=WASAPI Shared)");
		sw.WriteLine("; WASAPI can use on Vista or later OSs.");
		sw.WriteLine("; If WASAPI is not available, DTXMania try to use ASIO. If ASIO can't be used, ACM is used.");
		sw.WriteLine("SoundDeviceType={0}", (int)this.nSoundDeviceType);
		sw.WriteLine();

		sw.WriteLine("; Bass使用時のサウンドバッファサイズ");
		sw.WriteLine("; (0=デバイスに設定されている値を使用, 1～9999=バッファサイズ(単位:ms)の手動指定");
		sw.WriteLine("; Bass Sound Buffer Size.");
		sw.WriteLine("; (0=Use system default buffer size, 1-9999=specify the buffer size(ms) by yourself)");
		sw.WriteLine("BassBufferSizeMs={0}", (int)this.nBassBufferSizeMs);
		sw.WriteLine();

		sw.WriteLine("; WASAPI使用時のサウンドバッファサイズ");
		sw.WriteLine("; (0=デバイスに設定されている値を使用, 1～9999=バッファサイズ(単位:ms)の手動指定");
		sw.WriteLine("; WASAPI Sound Buffer Size.");
		sw.WriteLine("; (0=Use system default buffer size, 1-9999=specify the buffer size(ms) by yourself)");
		sw.WriteLine("WASAPIBufferSizeMs={0}", (int)this.nWASAPIBufferSizeMs);
		sw.WriteLine();

		sw.WriteLine("; ASIO使用時のサウンドデバイス");
		sw.WriteLine("; 存在しないデバイスを指定すると、DTXManiaが起動しないことがあります。");
		sw.WriteLine("; Sound device used by ASIO.");
		sw.WriteLine("; Don't specify unconnected device, as the DTXMania may not bootup.");
		if (OperatingSystem.IsWindows()) {
			string[] asiodev = CEnumerateAllAsioDevices.GetAllASIODevices();
			for (int i = 0; i < asiodev.Length; i++) {
				sw.WriteLine("; {0}: {1}", i, asiodev[i]);
			}
		}

		sw.WriteLine("ASIODevice={0}", (int)this.nASIODevice);
		sw.WriteLine();

		//sw.WriteLine( "; ASIO使用時のサウンドバッファサイズ" );
		//sw.WriteLine( "; (0=デバイスに設定されている値を使用, 1～9999=バッファサイズ(単位:ms)の手動指定" );
		//sw.WriteLine( "; ASIO Sound Buffer Size." );
		//sw.WriteLine( "; (0=Use the value specified to the device, 1-9999=specify the buffer size(ms) by yourself)" );
		//sw.WriteLine( "ASIOBufferSizeMs={0}", (int) this.nASIOBufferSizeMs );
		//sw.WriteLine();

		//sw.WriteLine( "; Bass.Mixの制御を動的に行うか否か。" );
		//sw.WriteLine( "; ONにすると、ギター曲などチップ音の多い曲も再生できますが、画面が少しがたつきます。" );
		//sw.WriteLine( "; (0=行わない, 1=行う)" );
		//sw.WriteLine( "DynamicBassMixerManagement={0}", this.bDynamicBassMixerManagement ? 1 : 0 );
		//sw.WriteLine();

		sw.WriteLine("; WASAPI/ASIO時に使用する演奏タイマーの種類");
		sw.WriteLine("; Playback timer used for WASAPI/ASIO");
		sw.WriteLine("; (0=FDK Timer, 1=System Timer)");
		sw.WriteLine("SoundTimerType={0}", this.bUseOSTimer ? 1 : 0);
		sw.WriteLine();

		//sw.WriteLine( "; 全体ボリュームの設定" );
		//sw.WriteLine( "; (0=無音 ～ 100=最大。WASAPI/ASIO時のみ有効)" );
		//sw.WriteLine( "; Master volume settings" );
		//sw.WriteLine( "; (0=Silent - 100=Max)" );
		//sw.WriteLine( "MasterVolume={0}", this.nMasterVolume );
		//sw.WriteLine();

		#endregion

		sw.WriteLine("; 背景画像の半透明割合(0:透明～255:不透明)");
		sw.WriteLine("; Transparency for background image in playing screen.(0:tranaparent - 255:no transparent)");
		sw.WriteLine("BGAlpha={0}", this.nBGAlpha);
		sw.WriteLine();

		#region [ AVI/BGA ]

		sw.WriteLine("; AVIの表示(0:OFF, 1:ON)");
		sw.WriteLine("AVI={0}", this.bEnableAVI ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; BGAの表示(0:OFF, 1:ON)");
		sw.WriteLine("BGA={0}", this.bEnableBGA ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; 動画表示モード( 0:表示しない, 1:背景のみ, 2:窓表示のみ, 3:両方)");
		sw.WriteLine("ClipDispType={0}", (int)this.eClipDispType);
		sw.WriteLine();

		#endregion

		#region [ プレビュー音 ]

		sw.WriteLine("; 曲選択からプレビュー音の再生までのウェイト[ms]");
		sw.WriteLine("PreviewSoundWait={0}", this.nMsWaitPreviewSoundFromSongSelected);
		sw.WriteLine();
		sw.WriteLine("; 曲選択からプレビュー画像表示までのウェイト[ms]");
		sw.WriteLine("PreviewImageWait={0}", this.nMsWaitPreviewImageFromSongSelected);
		sw.WriteLine();

		#endregion

		//sw.WriteLine( "; Waveの再生位置自動補正(0:OFF, 1:ON)" );
		//sw.WriteLine( "AdjustWaves={0}", this.bWave再生位置自動調整機能有効 ? 1 : 0 );

		#region [ BGM/ドラムヒット音の再生 ]

		sw.WriteLine("; BGM の再生(0:OFF, 1:ON)");
		sw.WriteLine("BGMSound={0}", this.bBGMPlayVoiceSound ? 1 : 0);
		sw.WriteLine();

		#endregion

		sw.WriteLine("; Hide Dan and Tower charts from the ensou song select screen (0:OFF, 1:ON)");
		sw.WriteLine("DanTowerHide={0}", this.bDanTowerHide ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; 最小表示コンボ数");
		sw.WriteLine("MinComboDrums={0}", this.nMinDisplayedCombo.Drums);
		sw.WriteLine();
		sw.WriteLine("; RANDOM SELECT で子BOXを検索対象に含める (0:OFF, 1:ON)");
		sw.WriteLine("RandomFromSubBox={0}", this.bIncludeSubfoldersOnRandomSelect ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; 演奏情報を表示する (0:OFF, 1:ON)");
		sw.WriteLine("; Showing playing info on the playing screen. (0:OFF, 1:ON)");
		sw.WriteLine("ShowDebugStatus={0}", this.bDisplayDebugInfo ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; BS1770GAIN によるラウドネスメータの測量を適用する (0:OFF, 1:ON)");
		sw.WriteLine("; Apply BS1770GAIN loudness metadata (0:OFF, 1:ON)");
		sw.WriteLine("{0}={1}", nameof(ApplyLoudnessMetadata), this.ApplyLoudnessMetadata ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine($"; BS1770GAIN によるラウドネスメータの目標値 (0). ({CSound.MinimumLufs}-{CSound.MaximumLufs})");
		sw.WriteLine(
			$"; Loudness Target in dB (decibels) relative to full scale (0). ({CSound.MinimumLufs}-{CSound.MaximumLufs})");
		sw.WriteLine("{0}={1}", nameof(TargetLoudness), TargetLoudness);
		sw.WriteLine();
		sw.WriteLine("; .tjaファイルのSONGVOLヘッダを音源の音量に適用する (0:OFF, 1:ON)");
		sw.WriteLine("; Apply SONGVOL (0:OFF, 1:ON)");
		sw.WriteLine("{0}={1}", nameof(ApplySongVol), this.ApplySongVol ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine($"; 効果音の音量 ({CSound.MinimumGroupLevel}-{CSound.MaximumGroupLevel}%)");
		sw.WriteLine($"; Sound effect level ({CSound.MinimumGroupLevel}-{CSound.MaximumGroupLevel}%)");
		sw.WriteLine("{0}={1}", nameof(SoundEffectLevel), SoundEffectLevel);
		sw.WriteLine();
		sw.WriteLine($"; 各ボイス、コンボボイスの音量 ({CSound.MinimumGroupLevel}-{CSound.MaximumGroupLevel}%)");
		sw.WriteLine($"; Voice level ({CSound.MinimumGroupLevel}-{CSound.MaximumGroupLevel}%)");
		sw.WriteLine("{0}={1}", nameof(VoiceLevel), VoiceLevel);
		sw.WriteLine();
		sw.WriteLine($"; 選曲画面のプレビュー時の音量 ({CSound.MinimumGroupLevel}-{CSound.MaximumGroupLevel}%)");
		sw.WriteLine($"; Song preview level ({CSound.MinimumGroupLevel}-{CSound.MaximumGroupLevel}%)");
		sw.WriteLine("{0}={1}", nameof(SongPreviewLevel), SongPreviewLevel);
		sw.WriteLine();
		sw.WriteLine($"; ゲーム中の音源の音量 ({CSound.MinimumGroupLevel}-{CSound.MaximumGroupLevel}%)");
		sw.WriteLine($"; Song playback level ({CSound.MinimumGroupLevel}-{CSound.MaximumGroupLevel}%)");
		sw.WriteLine("{0}={1}", nameof(SongPlaybackLevel), SongPlaybackLevel);
		sw.WriteLine();
		sw.WriteLine(
			$"; キーボードによる音量変更の増加量、減少量 ({MinimumKeyboardSoundLevelIncrement}-{MaximumKeyboardSoundLevelIncrement})");
		sw.WriteLine(
			$"; Keyboard sound level increment ({MinimumKeyboardSoundLevelIncrement}-{MaximumKeyboardSoundLevelIncrement})");
		sw.WriteLine("{0}={1}", nameof(KeyboardSoundLevelIncrement), KeyboardSoundLevelIncrement);
		sw.WriteLine($"; 音源再生前の空白時間 (ms) (最終値はこの値 + {MusicPreTimeMsOffset}ms)");
		sw.WriteLine($"; Blank time before music source to play. (ms) (Final value is this value + {MusicPreTimeMsOffset}ms");
		sw.WriteLine("{0}={1}", nameof(MusicPreTimeMs), MusicPreTimeMs - MusicPreTimeMsOffset);
		sw.WriteLine();
		sw.WriteLine("; バッファ入力モード(0:OFF, 1:ON)");
		sw.WriteLine("; Using Buffered input (0:OFF, 1:ON)");
		sw.WriteLine("BufferedInput={0}", this.bBufferedInputs ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; Set the deadzone for all connected controllers' thumbsticks.");
		sw.WriteLine("; Can be between 10% and 90%.");
		sw.WriteLine("ControllerDeadzone={0}", this.nControllerDeadzone);
		sw.WriteLine();
		sw.WriteLine("; リザルト画像自動保存機能(0:OFF, 1:ON)"); // #25399 2011.6.9 yyagi
		sw.WriteLine("; Set \"1\" if you'd like to save result screen image automatically"); //
		sw.WriteLine("; when you get hiscore/hiskill."); //
		sw.WriteLine("AutoResultCapture={0}", this.bIsAutoResultCapture ? 1 : 0); //
		sw.WriteLine();
		sw.WriteLine("; Discordに再生中の譜面情報を送信する(0:OFF, 1:ON)"); // #25399 2011.6.9 yyagi
		sw.WriteLine("; Share Playing .tja file infomation on Discord."); //
		sw.WriteLine("{0}={1}", nameof(SendDiscordPlayingInformation), SendDiscordPlayingInformation ? 1 : 0); //
		sw.WriteLine();
		sw.WriteLine("; 再生速度変更を、ピッチ変更で行うかどうか(0:ピッチ変更, 1:タイムストレッチ"); // #23664 2013.2.24 yyagi
		sw.WriteLine("; (WASAPI/ASIO使用時のみ有効) ");
		sw.WriteLine("; Set \"0\" if you'd like to use pitch shift with PlaySpeed."); //
		sw.WriteLine("; Set \"1\" for time stretch."); //
		sw.WriteLine("; (Only available when you're using using WASAPI or ASIO)"); //
		sw.WriteLine("TimeStretch={0}", this.bTimeStretch ? 1 : 0); //
		sw.WriteLine();
		//sw.WriteLine( "; WASAPI/ASIO使用時に、MP3をストリーム再生するかどうか(0:ストリーム再生する, 1:しない)" );			//
		//sw.WriteLine( "; (mp3のシークがおかしくなる場合は、これを1にしてください) " );	//
		//sw.WriteLine( "; Set \"0\" if you'd like to use mp3 streaming playback on WASAPI/ASIO." );		//
		//sw.WriteLine( "; Set \"1\" not to use streaming playback for mp3." );			//
		//sw.WriteLine( "; (If you feel illegal seek with mp3, please set it to 1.)" );	//
		//sw.WriteLine( "NoMP3Streaming={0}", this.bNoMP3Streaming ? 1 : 0 );				//
		//sw.WriteLine();
		sw.WriteLine("; 動画再生にDirectShowを使用する(0:OFF, 1:ON)");
		sw.WriteLine("; 動画再生にDirectShowを使うことによって、再生時の負担を軽減できます。");
		sw.WriteLine("; ただし使用時にはセットアップが必要になるのでご注意ください。");
		sw.WriteLine("DirectShowMode={0}", this.bDirectShowMode ? 1 : 0);
		sw.WriteLine();

		#region [ Adjust ]

		//sw.WriteLine( "; 判定タイミング調整(-9999～9999)[ms]" );
		//sw.WriteLine("; Revision value to adjust judgment timing.");	//
		//sw.WriteLine("InputAdjustTime={0}", this.nInputAdjustTimeMs);       //
		sw.WriteLine("GlobalOffset={0}", this.nGlobalOffsetMs);
		sw.WriteLine();

		#endregion

		sw.WriteLine("; TJAPlayer3のboxの表示をするかどうか (0:OFF, 1:ON)");
		sw.WriteLine("{0}={1}", nameof(TJAP3FolderMode), TJAP3FolderMode ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; 「また遊んでね」画面(0:OFF, 1:ON)");
		sw.WriteLine("EndingAnime={0}", this.bEndingAnime ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine(";-------------------");

		#endregion

		#region [ AutoPlay ]

		sw.WriteLine("[AutoPlay]");
		sw.WriteLine();
		sw.WriteLine("; 自動演奏(0:OFF, 1:ON)");
		sw.WriteLine("Taiko={0}", this.bAutoPlay[0] ? 1 : 0);
		sw.WriteLine("Taiko2P={0}", this.bAutoPlay[1] ? 1 : 0);
		sw.WriteLine("Taiko3P={0}", this.bAutoPlay[2] ? 1 : 0);
		sw.WriteLine("Taiko4P={0}", this.bAutoPlay[3] ? 1 : 0);
		sw.WriteLine("Taiko5P={0}", this.bAutoPlay[4] ? 1 : 0);
		sw.WriteLine("TaikoAutoRoll={0}", this.bAuto先生の連打 ? 1 : 0);
		sw.WriteLine("RollsPerSec={0}", this.nRollsPerSec);
		sw.WriteLine("DefaultAILevel={0}", this.nDefaultAILevel);
		sw.WriteLine();
		sw.WriteLine(";-------------------");

		#endregion

		#region [ Log ]

		sw.WriteLine("[Log]");
		sw.WriteLine();
		sw.WriteLine("; Log出力(0:OFF, 1:ON)");
		sw.WriteLine("OutputLog={0}", this.bOutputLogs ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; 曲データ検索に関するLog出力(0:OFF, 1:ON)");
		sw.WriteLine("TraceSongSearch={0}", this.bOutputSongSearchLog ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; 画像やサウンドの作成_解放に関するLog出力(0:OFF, 1:ON)");
		sw.WriteLine("TraceCreatedDisposed={0}", this.bOutputCreationReleaseLog ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; DTX読み込み詳細に関するLog出力(0:OFF, 1:ON)");
		sw.WriteLine("TraceDTXDetails={0}", this.bOutputDetailedDTXLog ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine(";-------------------");

		#endregion

		#region [ PlayOption ]

		sw.WriteLine("[PlayOption]");
		sw.WriteLine();
		sw.WriteLine("; 各画像の表示設定");
		sw.WriteLine("; キャラクター画像を表示する (0:OFF, 1:ON)");
		sw.WriteLine("ShowChara={0}", ShowChara ? 1 : 0);
		sw.WriteLine("; ダンサー画像を表示する (0:OFF, 1:ON)");
		sw.WriteLine("ShowDancer={0}", ShowDancer ? 1 : 0);
		sw.WriteLine("; ランナー画像を表示する (0:OFF, 1:ON)");
		sw.WriteLine("ShowRunner={0}", ShowRunner ? 1 : 0);
		sw.WriteLine("; モブ画像を表示する (0:OFF, 1:ON)");
		sw.WriteLine("ShowMob={0}", ShowMob ? 1 : 0);
		sw.WriteLine("; フッター画像 (0:OFF, 1:ON)");
		sw.WriteLine("ShowFooter={0}", ShowFooter ? 1 : 0);
		sw.WriteLine("; ぷちキャラ画像 (0:OFF, 1:ON)");
		sw.WriteLine("ShowPuchiChara={0}", ShowPuchiChara ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; 選曲画面でのタイマーを有効にするかどうか(0:無効,1:有効)");
		sw.WriteLine("; Enable countdown in songselect.(0:No, 1:Yes)");
		sw.WriteLine("EnableCountDownTimer={0}", this.bEnableCountdownTimer ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; ドラムREVERSEモード(0:OFF, 1:ON)");
		sw.WriteLine("DrumsReverse={0}", this.bReverse.Drums ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; RISKYモード(0:OFF, 1-10)"); // #23559 2011.6.23 yyagi
		sw.WriteLine("; RISKY mode. 0=OFF, 1-10 is the times of misses to be Failed."); //
		sw.WriteLine("Risky={0}", this.nRisky); //
		sw.WriteLine();
		sw.WriteLine("; TIGHTモード(0:OFF, 1:ON)"); // #29500 2012.9.11 kairera0467
		sw.WriteLine("; TIGHT mode. 0=OFF, 1=ON ");
		sw.WriteLine("DrumsTight={0}", this.bTight ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; ドラム譜面スクロール速度(0:x0.1, 9:x1.0, 14:x1.5,…,1999:x200.0)");
		sw.WriteLine("DrumsScrollSpeed1P={0}", this.nScrollSpeed[0]);
		sw.WriteLine("DrumsScrollSpeed2P={0}", this.nScrollSpeed[1]);
		sw.WriteLine("DrumsScrollSpeed3P={0}", this.nScrollSpeed[2]);
		sw.WriteLine("DrumsScrollSpeed4P={0}", this.nScrollSpeed[3]);
		sw.WriteLine("DrumsScrollSpeed5P={0}", this.nScrollSpeed[4]);
		sw.WriteLine();
		sw.WriteLine("; Timing Zones (0-1 : Lenient, 2 : Regular, 3-4 : Strict)");
		sw.WriteLine("TimingZones1P={0}", this.nTimingZones[0]);
		sw.WriteLine("TimingZones2P={0}", this.nTimingZones[1]);
		sw.WriteLine("TimingZones3P={0}", this.nTimingZones[2]);
		sw.WriteLine("TimingZones4P={0}", this.nTimingZones[3]);
		sw.WriteLine("TimingZones5P={0}", this.nTimingZones[4]);
		sw.WriteLine();
		sw.WriteLine("; Gametype (0 : Taiko, 1 : Bongo)");
		sw.WriteLine("Gametype1P={0}", (int)this.nGameType[0]);
		sw.WriteLine("Gametype2P={0}", (int)this.nGameType[1]);
		sw.WriteLine("Gametype3P={0}", (int)this.nGameType[2]);
		sw.WriteLine("Gametype4P={0}", (int)this.nGameType[3]);
		sw.WriteLine("Gametype5P={0}", (int)this.nGameType[4]);
		sw.WriteLine();
		sw.WriteLine(
			"; Fun Mods (0 : None, 1 : Avalanche (random scroll speed per note/chip), 2 : Minesweeper (replace randomly notes by bombs))");
		sw.WriteLine("FunMods1P={0}", (int)this.nFunMods[0]);
		sw.WriteLine("FunMods2P={0}", (int)this.nFunMods[1]);
		sw.WriteLine("FunMods3P={0}", (int)this.nFunMods[2]);
		sw.WriteLine("FunMods4P={0}", (int)this.nFunMods[3]);
		sw.WriteLine("FunMods5P={0}", (int)this.nFunMods[4]);
		sw.WriteLine();
		sw.WriteLine("; 演奏速度(5～40)(→x5/20～x40/20)");
		sw.WriteLine("PlaySpeed={0}", this.nSongSpeed);
		sw.WriteLine();

		sw.WriteLine("; 演奏速度が一倍速であるときのみBGMを再生する(0:OFF, 1:ON)");
		sw.WriteLine("PlaySpeedNotEqualOneNoSound={0}", this.bNoAudioIfNot1xSpeed ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; デフォルトで選択される難易度");
		sw.WriteLine("DefaultCourse={0}", this.nDefaultCourse);
		sw.WriteLine();
		sw.WriteLine("; スコア計算方法(0:旧配点, 1:旧筐体配点, 2:新配点)");
		sw.WriteLine("ScoreMode={0}", this.nScoreMode);
		sw.WriteLine();
		sw.WriteLine("; 真打モード (0:OFF, 1:ON)");
		sw.WriteLine("; Fixed score mode (0:OFF, 1:ON)");
		sw.WriteLine("{0}={1}", nameof(ShinuchiMode), ShinuchiMode ? 1 : 0);

		sw.WriteLine("; 大音符の両手入力待機時間(ms)");
		sw.WriteLine("BigNotesWaitTime={0}", this.nBigNoteWaitTimems);
		sw.WriteLine();
		sw.WriteLine("; 大音符の両手判定(0:OFF, 1:ON)");
		sw.WriteLine("BigNotesJudge={0}", this.bJudgeBigNotes ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; ゲージをNormalに強制(0:OFF, 1:ON)");
		sw.WriteLine("ForceNormalGauge={0}", this.bForceNormalGauge ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; NoInfo(0:OFF, 1:ON)");
		sw.WriteLine("NoInfo={0}", this.bNoInfo ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; 譜面分岐のアニメーション(0:7～14, 1:15)");
		sw.WriteLine("BranchAnime={0}", this.nBranchAnime);
		sw.WriteLine();
		sw.WriteLine("; デフォルトの曲ソート(0:絶対パス順, 1:ジャンル名ソートOLD, 2:ジャンル名ソートNEW )");
		sw.WriteLine("0:Path, 1:GenreName(AC8～AC14), 2GenreName(AC15～)");
		sw.WriteLine("DefaultSongSort={0}", this.nDefaultSongSort);
		sw.WriteLine("RecentlyPlayedMax={0}", this.nRecentlyPlayedMax);
		sw.WriteLine();
		sw.WriteLine(
			"; RANDOMモード(0:OFF, 1:Random (Kimagure), 2:Mirror (Abekobe) 3:SuperRandom (Detarame), 4:HyperRandom (Abekobe + Kimagure))");
		sw.WriteLine("TaikoRandom1P={0}", (int)this.eRandom[0]);
		sw.WriteLine("TaikoRandom2P={0}", (int)this.eRandom[1]);
		sw.WriteLine("TaikoRandom3P={0}", (int)this.eRandom[2]);
		sw.WriteLine("TaikoRandom4P={0}", (int)this.eRandom[3]);
		sw.WriteLine("TaikoRandom5P={0}", (int)this.eRandom[4]);
		sw.WriteLine();
		sw.WriteLine("; STEALTHモード(0:OFF, 1:ドロン, 2:ステルス)");
		sw.WriteLine("TaikoStealth1P={0}", (int)this.eSTEALTH[0]);
		sw.WriteLine("TaikoStealth2P={0}", (int)this.eSTEALTH[1]);
		sw.WriteLine("TaikoStealth3P={0}", (int)this.eSTEALTH[2]);
		sw.WriteLine("TaikoStealth4P={0}", (int)this.eSTEALTH[3]);
		sw.WriteLine("TaikoStealth5P={0}", (int)this.eSTEALTH[4]);
		sw.WriteLine();
		sw.WriteLine("; ゲーム(0:OFF, 1:完走!叩ききりまショー!, 2:完走!叩ききりまショー!(激辛) )");
		sw.WriteLine("GameMode={0}", (int)this.eGameMode);
		sw.WriteLine();
		sw.WriteLine();
		sw.WriteLine("; 特訓モード時にPgUp/PgDnで何小節飛ばすか");
		sw.WriteLine("TokkunSkipMeasures={0}", this.TokkunSkipMeasures);
		sw.WriteLine();
		sw.WriteLine("; 特訓モード時にジャンプポイントに飛ばすための時間(ms)");
		sw.WriteLine("; 指定ms以内に5回縁を叩きましょう");
		sw.WriteLine("{1}={0}", this.TokkunMashInterval, nameof(this.TokkunMashInterval));
		sw.WriteLine();
		sw.WriteLine("; JUST(0:OFF, 1:JUST, 2:SAFE)");
		sw.WriteLine("Just1P={0}", this.bJust[0]);
		sw.WriteLine("Just2P={0}", this.bJust[1]);
		sw.WriteLine("Just3P={0}", this.bJust[2]);
		sw.WriteLine("Just4P={0}", this.bJust[3]);
		sw.WriteLine();
		sw.WriteLine("; Hitsounds index (音色)");
		sw.WriteLine("HitSounds1P={0}", this.nHitSounds[0]);
		sw.WriteLine("HitSounds2P={0}", this.nHitSounds[1]);
		sw.WriteLine("HitSounds3P={0}", this.nHitSounds[2]);
		sw.WriteLine("HitSounds4P={0}", this.nHitSounds[3]);
		sw.WriteLine();
		sw.WriteLine("; 判定数の表示(0:OFF, 1:ON)");
		sw.WriteLine("JudgeCountDisplay={0}", this.bJudgeCountDisplay ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; 裏表移行アニメーションを有効する (0:OFF, 1:ON)");
		sw.WriteLine("ShowExExtraAnime={0}", this.ShowExExtraAnime ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine("; プレイ人数");
		sw.WriteLine("PlayerCount={0}", this.nPlayerCount);
		sw.WriteLine();


		sw.WriteLine(";-------------------");

		#endregion

		#region [ GUID ]

		sw.WriteLine("[GUID]");
		sw.WriteLine();
		foreach (KeyValuePair<int, string> pair in this.dicJoystick) {
			sw.WriteLine("JoystickID={0},{1}", pair.Key, pair.Value);
		}

		foreach (KeyValuePair<int, string> pair in this.dicGamepad) {
			sw.WriteLine("GamepadID={0},{1}", pair.Key, pair.Value);
		}

		#endregion

		#region [ DrumsKeyAssign ]

		sw.WriteLine();
		sw.WriteLine(";-------------------");
		sw.WriteLine("; キーアサイン");
		sw.WriteLine(";   項　目：Keyboard → 'K'＋'0'＋キーコード(10進数)");
		sw.WriteLine(";           Mouse    → 'N'＋'0'＋ボタン番号(0～7)");
		sw.WriteLine(";           MIDI In  → 'M'＋デバイス番号1桁(0～9,A～Z)＋ノート番号(10進数)");
		sw.WriteLine(";           Joystick → 'J'＋デバイス番号1桁(0～9,A～Z)＋ 0 ...... Ｘ減少(左)ボタン");
		sw.WriteLine(";                                                         1 ...... Ｘ増加(右)ボタン");
		sw.WriteLine(";                                                         2 ...... Ｙ減少(上)ボタン");
		sw.WriteLine(";                                                         3 ...... Ｙ増加(下)ボタン");
		sw.WriteLine(";                                                         4 ...... Ｚ減少(前)ボタン");
		sw.WriteLine(";                                                         5 ...... Ｚ増加(後)ボタン");
		sw.WriteLine(";                                                         6～133.. ボタン1～128");
		sw.WriteLine(";           これらの項目を 16 個まで指定可能(',' で区切って記述）。");
		sw.WriteLine(";");
		sw.WriteLine(";   表記例：HH=K044,M042,J16");
		sw.WriteLine(";           → HiHat を Keyboard の 44 ('Z'), MidiIn#0 の 42, JoyPad#1 の 6(ボタン1) に割当て");
		sw.WriteLine(";");
		sw.WriteLine(";   ※Joystick のデバイス番号とデバイスとの関係は [GUID] セクションに記してあるものが有効。");
		sw.WriteLine(";");
		sw.WriteLine();
		sw.WriteLine("[DrumsKeyAssign]");
		sw.WriteLine();

		sw.Write("LeftRed=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.LeftRed);
		sw.WriteLine();
		sw.Write("RightRed=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.RightRed);
		sw.WriteLine();
		sw.Write("LeftBlue="); // #27029 2012.1.4 from
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.LeftBlue); //
		sw.WriteLine(); //
		sw.Write("RightBlue="); // #27029 2012.1.4 from
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.RightBlue); //
		sw.WriteLine();

		sw.Write("LeftRed2P=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.LeftRed2P);
		sw.WriteLine();
		sw.Write("RightRed2P=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.RightRed2P);
		sw.WriteLine();
		sw.Write("LeftBlue2P="); // #27029 2012.1.4 from
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.LeftBlue2P); //
		sw.WriteLine(); //
		sw.Write("RightBlue2P="); // #27029 2012.1.4 from
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.RightBlue2P); //
		sw.WriteLine();

		sw.Write("LeftRed3P=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.LeftRed3P);
		sw.WriteLine();
		sw.Write("RightRed3P=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.RightRed3P);
		sw.WriteLine();
		sw.Write("LeftBlue3P="); // #27029 2012.1.4 from
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.LeftBlue3P); //
		sw.WriteLine(); //
		sw.Write("RightBlue3P="); // #27029 2012.1.4 from
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.RightBlue3P); //
		sw.WriteLine();

		sw.Write("LeftRed4P=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.LeftRed4P);
		sw.WriteLine();
		sw.Write("RightRed4P=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.RightRed4P);
		sw.WriteLine();
		sw.Write("LeftBlue4P="); // #27029 2012.1.4 from
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.LeftBlue4P); //
		sw.WriteLine(); //
		sw.Write("RightBlue4P="); // #27029 2012.1.4 from
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.RightBlue4P); //
		sw.WriteLine();

		sw.Write("LeftRed5P=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.LeftRed5P);
		sw.WriteLine();
		sw.Write("RightRed5P=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.RightRed5P);
		sw.WriteLine();
		sw.Write("LeftBlue5P="); // #27029 2012.1.4 from
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.LeftBlue5P); //
		sw.WriteLine(); //
		sw.Write("RightBlue5P="); // #27029 2012.1.4 from
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.RightBlue5P); //
		sw.WriteLine();

		sw.Write("Clap=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.Clap);
		sw.WriteLine();
		sw.Write("Clap2P=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.Clap2P);
		sw.WriteLine();
		sw.Write("Clap3P=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.Clap3P);
		sw.WriteLine();
		sw.Write("Clap4P=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.Clap4P);
		sw.WriteLine();
		sw.Write("Clap5P=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.Clap5P);
		sw.WriteLine();

		sw.Write("Decide=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.Decide);
		sw.WriteLine();
		sw.Write("Cancel=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.Cancel);
		sw.WriteLine();
		sw.Write("LeftChange=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.LeftChange);
		sw.WriteLine();
		sw.Write("RightChange=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.RightChange);
		sw.WriteLine();

		sw.WriteLine();

		#endregion

		#region [ SystemKeyAssign ]

		sw.WriteLine("[SystemKeyAssign]");
		sw.WriteLine();
		sw.Write("Capture=");
		this.WriteKeyAssignment(sw, this.KeyAssign.System.Capture);
		sw.WriteLine();
		sw.Write("SongVolumeIncrease=");
		this.WriteKeyAssignment(sw, this.KeyAssign.System.SongVolIncrease);
		sw.WriteLine();
		sw.Write("SongVolumeDecrease=");
		this.WriteKeyAssignment(sw, this.KeyAssign.System.SongVolDecrease);
		sw.WriteLine();
		sw.Write("DisplayHits=");
		this.WriteKeyAssignment(sw, this.KeyAssign.System.DisplayHits);
		sw.WriteLine();
		sw.Write("DisplayDebug=");
		this.WriteKeyAssignment(sw, this.KeyAssign.System.DisplayDebug);
		sw.WriteLine();
		sw.Write("QuickConfig=");
		this.WriteKeyAssignment(sw, this.KeyAssign.System.QuickConfig);
		sw.WriteLine();
		sw.Write("NewHeya=");
		this.WriteKeyAssignment(sw, this.KeyAssign.System.NewHeya);
		sw.WriteLine();
		sw.Write("SortSongs=");
		this.WriteKeyAssignment(sw, this.KeyAssign.System.SortSongs);
		sw.WriteLine();
		sw.Write("ToggleAutoP1=");
		this.WriteKeyAssignment(sw, this.KeyAssign.System.ToggleAutoP1);
		sw.WriteLine();
		sw.Write("ToggleAutoP2=");
		this.WriteKeyAssignment(sw, this.KeyAssign.System.ToggleAutoP2);
		sw.WriteLine();
		sw.Write("ToggleTrainingMode=");
		this.WriteKeyAssignment(sw, this.KeyAssign.System.ToggleTrainingMode);
		sw.WriteLine();
		sw.Write("CycleVideoDisplayMode=");
		this.WriteKeyAssignment(sw, this.KeyAssign.System.CycleVideoDisplayMode);
		sw.WriteLine();
		sw.WriteLine();

		#endregion

		#region [ TrainingKeyAssign ]

		sw.WriteLine("[TrainingKeyAssign]");
		sw.WriteLine();
		sw.Write("TrainingIncreaseScrollSpeed=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.TrainingIncreaseScrollSpeed);
		sw.WriteLine();
		sw.Write("TrainingDecreaseScrollSpeed=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.TrainingDecreaseScrollSpeed);
		sw.WriteLine();
		sw.Write("TrainingIncreaseSongSpeed=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.TrainingIncreaseSongSpeed);
		sw.WriteLine();
		sw.Write("TrainingDecreaseSongSpeed=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.TrainingDecreaseSongSpeed);
		sw.WriteLine();
		sw.Write("TrainingToggleAuto=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.TrainingToggleAuto);
		sw.WriteLine();
		sw.Write("TrainingBranchNormal=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.TrainingBranchNormal);
		sw.WriteLine();
		sw.Write("TrainingBranchExpert=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.TrainingBranchExpert);
		sw.WriteLine();
		sw.Write("TrainingBranchMaster=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.TrainingBranchMaster);
		sw.WriteLine();
		sw.Write("TrainingPause=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.TrainingPause);
		sw.WriteLine();
		sw.Write("TrainingBookmark=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.TrainingBookmark);
		sw.WriteLine();
		sw.Write("TrainingMoveForwardMeasure=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.TrainingMoveForwardMeasure);
		sw.WriteLine();
		sw.Write("TrainingMoveBackMeasure=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.TrainingMoveBackMeasure);
		sw.WriteLine();
		sw.Write("TrainingSkipForwardMeasure=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.TrainingSkipForwardMeasure);
		sw.WriteLine();
		sw.Write("TrainingSkipBackMeasure=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.TrainingSkipBackMeasure);
		sw.WriteLine();
		sw.Write("TrainingJumpToFirstMeasure=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.TrainingJumpToFirstMeasure);
		sw.WriteLine();
		sw.Write("TrainingJumpToLastMeasure=");
		this.WriteKeyAssignment(sw, this.KeyAssign.Drums.TrainingJumpToLastMeasure);
		sw.WriteLine();
		sw.WriteLine();

		#endregion

		#region [DEBUG]

		sw.WriteLine("[DEBUG]");
		sw.WriteLine();
		sw.WriteLine("ImGui={0}", this.DEBUG_bShowImgui ? 1 : 0);
		sw.WriteLine();
		sw.WriteLine();

		#endregion

		sw.Close();
	}

	public void LoadFromFile(string iniFileName) {
		this.ConfigIniFileName = iniFileName;
		this.bConfigIniFileExists = File.Exists(this.ConfigIniFileName);
		if (!this.bConfigIniFileExists) {
			return;
		}

		string str;
		this.ClearAllKeyAssignments();
		using (StreamReader reader =
			   new StreamReader(this.ConfigIniFileName, Encoding.GetEncoding(OpenTaiko.sEncType))) {
			str = reader.ReadToEnd();
		}

		this.LoadFromString(str);
	}

	private void LoadFromString(string strAllSettings) {
		ESectionType currentSectionType = ESectionType.Unknown;
		string[] delimiter = { "\n" };
		string[] strSingleLine = strAllSettings.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
		foreach (string s in strSingleLine) {
			string line = s.Replace('\t', ' ')
				.TrimStart(new char[] { '\t', ' ' });
			if ((line.Length == 0) || (line[0] == ';')) {
				continue;
			}

			try {
				if (line[0] == '[') {
					StringBuilder builder = new StringBuilder(0x20);
					int num = 1;
					while ((num < line.Length) && (line[num] != ']')) {
						builder.Append(line[num++]);
					}

					string sectionName = builder.ToString();
					currentSectionType = sectionName switch {
						"System" => ESectionType.System,
						"AutoPlay" => ESectionType.AutoPlay,
						"HitRange" => ESectionType.HitRange,
						"Log" => ESectionType.Log,
						"PlayOption" => ESectionType.PlayOption,
						"ViewerOption" => ESectionType.ViewerOption,
						"GUID" => ESectionType.GUID,
						"DrumsKeyAssign" => ESectionType.DrumsKeyAssign,
						"SystemKeyAssign" => ESectionType.SystemKeyAssign,
						"TrainingKeyAssign" => ESectionType.TrainingKeyAssign,
						"DEBUG" => ESectionType.DEBUG,
						"Temp" => ESectionType.Temp,
						_ => ESectionType.Unknown
					};
				} else {
					string[] keyValuePair = line.Split(new char[] { '=' });
					if (keyValuePair.Length == 2) {
						string key = keyValuePair[0].Trim();
						string value = keyValuePair[1].Trim();
						if (this.sectionProcess.TryGetValue(currentSectionType, out var processSection)) {
							processSection(key, value);
						}
					}
				}
			} catch (Exception exception) {
				Trace.TraceError(exception.ToString());
				Trace.TraceError("例外が発生しましたが処理を継続します。 (93c4c5cd-4996-4e8c-a82f-a179ff590b44)");
			}
		}
	}

	private void ProcessSystemSection(string key, string value) {
		switch (key) {
			case "TJAPath":
				this.strSongsPath = value;
				break;
			case "Lang":
				this.sLang = value;
				CLangManager.langAttach(value);
				break;
			case "LayoutType":
				this.nLayoutType = int.Parse(value);
				break;
			case "SaveFileName": {
					var _s = value.Split(new char[] { ',' });

					// Ignore custom save file names if duplicates
					if (!_s.GroupBy(x => x).Any(g => g.Count() > 1)) {
						for (int i = 0; i < Math.Min(5, _s.Length); i++) {
							this.sSaveFile[i] = _s[i];
						}
					}

					break;
				}
			case "IgnoreSongUnlockables":
				this.bIgnoreSongUnlockables = CConversion.bONorOFF(value[0]);
				break;
			case "SkinPath": {
					string absSkinPath = value;
					if (!System.IO.Path.IsPathRooted(value)) {
						absSkinPath = System.IO.Path.Combine(OpenTaiko.strEXEのあるフォルダ, "System");
						absSkinPath = System.IO.Path.Combine(absSkinPath, value);
						Uri u = new Uri(absSkinPath);
						absSkinPath = u.AbsolutePath.ToString(); // str4内に相対パスがある場合に備える
						absSkinPath = System.Web.HttpUtility.UrlDecode(absSkinPath); // デコードする
						absSkinPath =
							absSkinPath.Replace('/', System.IO.Path.DirectorySeparatorChar); // 区切り文字が\ではなく/なので置換する
					}

					if (absSkinPath[absSkinPath.Length - 1] !=
						System.IO.Path.DirectorySeparatorChar) // フォルダ名末尾に\を必ずつけて、CSkin側と表記を統一する
					{
						absSkinPath += System.IO.Path.DirectorySeparatorChar;
					}

					this.strSystemSkinSubfolderFullName = absSkinPath;
					break;
				}
			case nameof(this.PreAssetsLoading):
				this.PreAssetsLoading = CConversion.bONorOFF(value[0]);
				break;
			case nameof(this.FastRender):
				this.FastRender = CConversion.bONorOFF(value[0]);
				break;
			case nameof(this.ASyncTextureLoad):
				this.ASyncTextureLoad = CConversion.bONorOFF(value[0]);
				break;
			case nameof(this.SimpleMode):
				this.SimpleMode = CConversion.bONorOFF(value[0]);
				break;
			case "GraphicsDeviceType":
				this.nGraphicsDeviceType = CConversion.ParseIntInRange(value, 0, 4, this.nGraphicsDeviceType);
				break;
			case "FullScreen":
				this.bFullScreen = CConversion.bONorOFF(value[0]);
				break;
			case "WindowX":
				this.nWindowBaseXPosition = CConversion.ParseIntInRange(
					value, 0, 9999, this.nWindowBaseXPosition);
				break;
			case "WindowY":
				this.nWindowBaseYPosition = CConversion.ParseIntInRange(
					value, 0, 9999, this.nWindowBaseYPosition);
				break;
			case "WindowWidth": {
					this.nWindowWidth = CConversion.ParseIntInRange(value, 1, 65535, this.nWindowWidth);
					if (this.nWindowWidth <= 0) {
						this.nWindowWidth = GameWindowSize.Width;
					}

					break;
				}
			case "WindowHeight": {
					this.nWindowHeight = CConversion.ParseIntInRange(value, 1, 65535, this.nWindowHeight);
					if (this.nWindowHeight <= 0) {
						this.nWindowHeight = GameWindowSize.Height;
					}

					break;
				}
			case "DoubleClickFullScreen":
				this.bIsAllowedDoubleClickFullscreen = CConversion.bONorOFF(value[0]);
				break;
			case "EnableSystemMenu":
				this.bIsEnabledSystemMenu = CConversion.bONorOFF(value[0]);
				break;
			case "BackSleep":
				this.nMsSleepUnfocused = CConversion.ParseIntInRangeAndClamp(value, 0, 50, this.nMsSleepUnfocused);
				break;
			case "SoundDeviceType":
				this.nSoundDeviceType = CConversion.ParseIntInRange(value, 0, 4, this.nSoundDeviceType);
				break;
			case "BassBufferSizeMs":
				this.nBassBufferSizeMs = CConversion.ParseIntInRange(value, 0, 9999, this.nBassBufferSizeMs);
				break;
			case "WASAPIBufferSizeMs":
				this.nWASAPIBufferSizeMs = CConversion.ParseIntInRange(value, 0, 9999, this.nWASAPIBufferSizeMs);
				break;
			case "ASIODevice": {
					if (OperatingSystem.IsWindows()) {
						string[] asiodev = CEnumerateAllAsioDevices.GetAllASIODevices();
						this.nASIODevice = CConversion.ParseIntInRange(value, 0, asiodev.Length - 1, this.nASIODevice);
					}
					else {
						this.nASIODevice = 0;
					}
					break;
				}
			case "SoundTimerType":
				this.bUseOSTimer = CConversion.bONorOFF(value[0]);
				break;
			case "FontName":
				this.FontName = value;
				break;
			case "BoxFontName":
				this.BoxFontName = value;
				break;
			case "VSyncWait":
				this.bEnableVSync = CConversion.bONorOFF(value[0]);
				break;
			case "SleepTimePerFrame":
				this.nMsSleepPerFrame = CConversion.ParseIntInRangeAndClamp(value, -1, 50, this.nMsSleepPerFrame);
				break;
			case "BGAlpha":
				this.nBackgroundTransparency =
					CConversion.ParseIntInRange(value, 0, 0xff, this.nBackgroundTransparency);
				break;
			case "AVI":
				this.bEnableAVI = CConversion.bONorOFF(value[0]);
				break;
			case "BGA":
				this.bEnableBGA = CConversion.bONorOFF(value[0]);
				break;
			case "ClipDispType":
				this.eClipDispType =
					(EClipDispType)CConversion.ParseIntInRange(value, 0, 3, (int)this.eClipDispType);
				break;
			case "PreviewSoundWait":
				this.nMsWaitPreviewSoundFromSongSelected = CConversion.ParseIntInRange(value, 0, 0x5f5e0ff,
					this.nMsWaitPreviewSoundFromSongSelected);
				break;
			case "PreviewImageWait":
				this.nMsWaitPreviewImageFromSongSelected = CConversion.ParseIntInRange(value, 0, 0x5f5e0ff,
					this.nMsWaitPreviewImageFromSongSelected);
				break;
			case "BGMSound":
				this.bBGMPlayVoiceSound = CConversion.bONorOFF(value[0]);
				break;
			case "DanTowerHide":
				this.bDanTowerHide = CConversion.bONorOFF(value[0]);
				break;
			case "RandomFromSubBox":
				this.bIncludeSubfoldersOnRandomSelect = CConversion.bONorOFF(value[0]);
				break;
			case "MinComboDrums":
				this.nMinDisplayedCombo.Drums =
					CConversion.ParseIntInRange(value, 1, 0x1869f, this.nMinDisplayedCombo.Drums);
				break;
			case "ShowDebugStatus":
				this.bDisplayDebugInfo = CConversion.bONorOFF(value[0]);
				break;
			case nameof(this.ApplyLoudnessMetadata):
				this.ApplyLoudnessMetadata = CConversion.bONorOFF(value[0]);
				break;
			case nameof(this.TargetLoudness):
				this.TargetLoudness = CConversion.ParseDoubleInRange(value, CSound.MinimumLufs.ToDouble(),
					CSound.MaximumLufs.ToDouble(), this.TargetLoudness);
				break;
			case nameof(this.ApplySongVol):
				this.ApplySongVol = CConversion.bONorOFF(value[0]);
				break;
			case nameof(this.SoundEffectLevel):
				this.SoundEffectLevel = CConversion.ParseIntInRange(value, CSound.MinimumGroupLevel,
					CSound.MaximumGroupLevel, this.SoundEffectLevel);
				break;
			case nameof(this.VoiceLevel):
				this.VoiceLevel = CConversion.ParseIntInRange(value, CSound.MinimumGroupLevel,
					CSound.MaximumGroupLevel, this.VoiceLevel);
				break;
			case nameof(this.SongPreviewLevel):
				this.SongPreviewLevel = CConversion.ParseIntInRange(value, CSound.MinimumGroupLevel,
					CSound.MaximumGroupLevel, this.SongPreviewLevel);
				break;
			case nameof(this.SongPlaybackLevel):
				this.SongPlaybackLevel = CConversion.ParseIntInRange(value, CSound.MinimumGroupLevel,
					CSound.MaximumGroupLevel, this.SongPlaybackLevel);
				break;
			case nameof(this.KeyboardSoundLevelIncrement):
				this.KeyboardSoundLevelIncrement = CConversion.ParseIntInRange(value,
					MinimumKeyboardSoundLevelIncrement, MaximumKeyboardSoundLevelIncrement,
					this.KeyboardSoundLevelIncrement);
				break;
			case nameof(this.MusicPreTimeMs):
				this.MusicPreTimeMs = int.Parse(value) + MusicPreTimeMsOffset;
				break;
			case "AutoResultCapture":
				this.bIsAutoResultCapture = CConversion.bONorOFF(value[0]);
				break;
			case nameof(this.SendDiscordPlayingInformation):
				this.SendDiscordPlayingInformation = CConversion.bONorOFF(value[0]);
				break;
			case "TimeStretch":
				this.bTimeStretch = CConversion.bONorOFF(value[0]);
				break;
			case "GlobalOffset":
				this.nGlobalOffsetMs = CConversion.ParseIntInRange(value, -9999, 9999, this.nGlobalOffsetMs);
				break;
			case "BufferedInput":
				this.bBufferedInputs = CConversion.bONorOFF(value[0]);
				break;
			case "ControllerDeadzone":
				this.nControllerDeadzone = CConversion.ParseIntInRange(value, 10, 90, this.nControllerDeadzone);
				break;
			case "PolyphonicSounds":
				this.nPoliphonicSounds = CConversion.ParseIntInRange(value, 1, 8, this.nPoliphonicSounds);
				break;
			case "LCVelocityMin":
				this.nVelocityMin.LC = CConversion.ParseIntInRange(value, 0, 127, this.nVelocityMin.LC);
				break;
			case "HHVelocityMin":
				this.nVelocityMin.HH = CConversion.ParseIntInRange(value, 0, 127, this.nVelocityMin.HH);
				break;
			case "SDVelocityMin":
				this.nVelocityMin.SD = CConversion.ParseIntInRange(value, 0, 127, this.nVelocityMin.SD);
				break;
			case "BDVelocityMin":
				this.nVelocityMin.BD = CConversion.ParseIntInRange(value, 0, 127, this.nVelocityMin.BD);
				break;
			case "HTVelocityMin":
				this.nVelocityMin.HT = CConversion.ParseIntInRange(value, 0, 127, this.nVelocityMin.HT);
				break;
			case "LTVelocityMin":
				this.nVelocityMin.LT = CConversion.ParseIntInRange(value, 0, 127, this.nVelocityMin.LT);
				break;
			case "FTVelocityMin":
				this.nVelocityMin.FT = CConversion.ParseIntInRange(value, 0, 127, this.nVelocityMin.FT);
				break;
			case "CYVelocityMin":
				this.nVelocityMin.CY = CConversion.ParseIntInRange(value, 0, 127, this.nVelocityMin.CY);
				break;
			case "RDVelocityMin":
				this.nVelocityMin.RD = CConversion.ParseIntInRange(value, 0, 127, this.nVelocityMin.RD);
				break;
			case "DirectShowMode":
				this.bDirectShowMode = CConversion.bONorOFF(value[0]);
				;
				break;
			case nameof(this.TJAP3FolderMode):
				this.TJAP3FolderMode = CConversion.bONorOFF(value[0]);
				break;
			case "EndingAnime":
				this.bEndingAnime = CConversion.bONorOFF(value[0]);
				break;
		}
	}

	private void ProcessAutoPlaySection(string key, string value) {
		switch (key) {
			case "Taiko":
				this.bAutoPlay[0] = CConversion.bONorOFF(value[0]);
				break;
			case "Taiko2P":
				this.bAutoPlay[1] = CConversion.bONorOFF(value[0]);
				break;
			case "Taiko3P":
				this.bAutoPlay[2] = CConversion.bONorOFF(value[0]);
				break;
			case "Taiko4P":
				this.bAutoPlay[3] = CConversion.bONorOFF(value[0]);
				break;
			case "Taiko5P":
				this.bAutoPlay[4] = CConversion.bONorOFF(value[0]);
				break;
			case "TaikoAutoRoll":
				this.bAuto先生の連打 = CConversion.bONorOFF(value[0]);
				break;
			case "RollsPerSec":
				this.nRollsPerSec = int.Parse(value);
				break;
			case "DefaultAILevel":
				this.nDefaultAILevel = int.Parse(value);
				this.nAILevel = this.nDefaultAILevel;
				break;
		}
	}

	private void ProcessHitRangeSection(string key, string value) {
		switch (key) {
			case "Perfect":
				this.nHitRangeMs.Perfect =
					CConversion.ParseIntInRange(value, 0, 0x3e7, this.nHitRangeMs.Perfect);
				break;
			case "Great":
				this.nHitRangeMs.Great =
					CConversion.ParseIntInRange(value, 0, 0x3e7, this.nHitRangeMs.Great);
				break;
			case "Good":
				this.nHitRangeMs.Good =
					CConversion.ParseIntInRange(value, 0, 0x3e7, this.nHitRangeMs.Good);
				break;
			case "Poor":
				this.nHitRangeMs.Poor =
					CConversion.ParseIntInRange(value, 0, 0x3e7, this.nHitRangeMs.Poor);
				break;
		}
	}

	private void ProcessLogSection(string key, string value) {
		switch (key) {
			case "OutputLog":
				this.bOutputLogs = CConversion.bONorOFF(value[0]);
				break;
			case "TraceCreatedDisposed":
				this.bOutputCreationReleaseLog = CConversion.bONorOFF(value[0]);
				break;
			case "TraceDTXDetails":
				this.bOutputDetailedDTXLog = CConversion.bONorOFF(value[0]);
				break;
			case "TraceSongSearch":
				this.bOutputSongSearchLog = CConversion.bONorOFF(value[0]);
				break;
		}
	}

	private void ProcessPlayOptionSection(string key, string value) {
		switch (key) {
			case "ShowChara":
				this.ShowChara = CConversion.bONorOFF(value[0]);
				break;
			case "ShowDancer":
				this.ShowDancer = CConversion.bONorOFF(value[0]);
				break;
			case "ShowRunner":
				this.ShowRunner = CConversion.bONorOFF(value[0]);
				break;
			case "ShowMob":
				this.ShowMob = CConversion.bONorOFF(value[0]);
				break;
			case "ShowFooter":
				this.ShowFooter = CConversion.bONorOFF(value[0]);
				break;
			case "ShowPuchiChara":
				this.ShowPuchiChara = CConversion.bONorOFF(value[0]);
				break;
			case "EnableCountDownTimer":
				this.bEnableCountdownTimer = CConversion.bONorOFF(value[0]);
				break;
			case "DrumsReverse":
				this.bReverse.Drums = CConversion.bONorOFF(value[0]);
				break;
			case "DrumsPosition":
				this.JudgeTextDisplayPosition.Drums =
					(EJudgeTextDisplayPosition)CConversion.ParseIntInRange(value, 0, 2,
						(int)this.JudgeTextDisplayPosition.Drums);
				break;
			case "DrumsScrollSpeed":
			case "DrumsScrollSpeed1P":
				this.nScrollSpeed[0] =
					CConversion.ParseIntInRange(value, 0, 0x7cf, this.nScrollSpeed[0]);
				break;
			case "DrumsScrollSpeed2P":
				this.nScrollSpeed[1] =
					CConversion.ParseIntInRange(value, 0, 0x7cf, this.nScrollSpeed[1]);
				break;
			case "DrumsScrollSpeed3P":
				this.nScrollSpeed[2] =
					CConversion.ParseIntInRange(value, 0, 0x7cf, this.nScrollSpeed[2]);
				break;
			case "DrumsScrollSpeed4P":
				this.nScrollSpeed[3] =
					CConversion.ParseIntInRange(value, 0, 0x7cf, this.nScrollSpeed[3]);
				break;
			case "DrumsScrollSpeed5P":
				this.nScrollSpeed[4] =
					CConversion.ParseIntInRange(value, 0, 0x7cf, this.nScrollSpeed[4]);
				break;
			case "TimingZones1P":
				this.nTimingZones[0] =
					CConversion.ParseIntInRange(value, 0, 4, this.nTimingZones[0]);
				break;
			case "TimingZones2P":
				this.nTimingZones[1] =
					CConversion.ParseIntInRange(value, 0, 4, this.nTimingZones[1]);
				break;
			case "TimingZones3P":
				this.nTimingZones[2] =
					CConversion.ParseIntInRange(value, 0, 4, this.nTimingZones[2]);
				break;
			case "TimingZones4P":
				this.nTimingZones[3] =
					CConversion.ParseIntInRange(value, 0, 4, this.nTimingZones[3]);
				break;
			case "TimingZones5P":
				this.nTimingZones[4] =
					CConversion.ParseIntInRange(value, 0, 4, this.nTimingZones[4]);
				break;
			case "Just":
			case "Just1P":
				this.bJust[0] = CConversion.ParseIntInRange(value, 0, 2, this.bJust[0]);
				break;
			case "Just2P":
				this.bJust[1] = CConversion.ParseIntInRange(value, 0, 2, this.bJust[1]);
				break;
			case "Just3P":
				this.bJust[2] = CConversion.ParseIntInRange(value, 0, 2, this.bJust[2]);
				break;
			case "Just4P":
				this.bJust[3] = CConversion.ParseIntInRange(value, 0, 2, this.bJust[3]);
				break;
			case "Just5P":
				this.bJust[4] = CConversion.ParseIntInRange(value, 0, 2, this.bJust[4]);
				break;
			case "HitSounds1P":
				this.nHitSounds[0] =
					CConversion.ParseIntInRange(value, 0, 9999999, this.nHitSounds[0]);
				break;
			case "HitSounds2P":
				this.nHitSounds[1] =
					CConversion.ParseIntInRange(value, 0, 9999999, this.nHitSounds[1]);
				break;
			case "HitSounds3P":
				this.nHitSounds[2] =
					CConversion.ParseIntInRange(value, 0, 9999999, this.nHitSounds[2]);
				break;
			case "HitSounds4P":
				this.nHitSounds[3] =
					CConversion.ParseIntInRange(value, 0, 9999999, this.nHitSounds[3]);
				break;
			case "HitSounds5P":
				this.nHitSounds[4] =
					CConversion.ParseIntInRange(value, 0, 9999999, this.nHitSounds[4]);
				break;
			case "Gametype1P":
				this.nGameType[0] =
					(EGameType)CConversion.ParseIntInRange(value, 0, 1, (int)this.nGameType[0]);
				break;
			case "Gametype2P":
				this.nGameType[1] =
					(EGameType)CConversion.ParseIntInRange(value, 0, 1, (int)this.nGameType[1]);
				break;
			case "Gametype3P":
				this.nGameType[2] =
					(EGameType)CConversion.ParseIntInRange(value, 0, 1, (int)this.nGameType[2]);
				break;
			case "Gametype4P":
				this.nGameType[3] =
					(EGameType)CConversion.ParseIntInRange(value, 0, 1, (int)this.nGameType[3]);
				break;
			case "Gametype5P":
				this.nGameType[4] =
					(EGameType)CConversion.ParseIntInRange(value, 0, 1, (int)this.nGameType[4]);
				break;
			case "FunMods1P":
				this.nFunMods[0] =
					(EFunMods)CConversion.ParseIntInRange(value, 0, (int)EFunMods.Total - 1, (int)this.nFunMods[0]);
				break;
			case "FunMods2P":
				this.nFunMods[1] =
					(EFunMods)CConversion.ParseIntInRange(value, 0, (int)EFunMods.Total - 1, (int)this.nFunMods[1]);
				break;
			case "FunMods3P":
				this.nFunMods[2] =
					(EFunMods)CConversion.ParseIntInRange(value, 0, (int)EFunMods.Total - 1, (int)this.nFunMods[2]);
				break;
			case "FunMods4P":
				this.nFunMods[3] =
					(EFunMods)CConversion.ParseIntInRange(value, 0, (int)EFunMods.Total - 1, (int)this.nFunMods[3]);
				break;
			case "FunMods5P":
				this.nFunMods[4] =
					(EFunMods)CConversion.ParseIntInRange(value, 0, (int)EFunMods.Total - 1, (int)this.nFunMods[4]);
				break;
			case "TaikoStealth1P":
			case "TaikoStealth":
				this.eSTEALTH[0] =
					(EStealthMode)CConversion.ParseIntInRange(value, 0, 3, (int)this.eSTEALTH[0]);
				break;
			case "TaikoStealth2P":
				this.eSTEALTH[1] =
					(EStealthMode)CConversion.ParseIntInRange(value, 0, 3, (int)this.eSTEALTH[1]);
				break;
			case "TaikoStealth3P":
				this.eSTEALTH[2] =
					(EStealthMode)CConversion.ParseIntInRange(value, 0, 3, (int)this.eSTEALTH[2]);
				break;
			case "TaikoStealth4P":
				this.eSTEALTH[3] =
					(EStealthMode)CConversion.ParseIntInRange(value, 0, 3, (int)this.eSTEALTH[3]);
				break;
			case "TaikoStealth5P":
				this.eSTEALTH[4] =
					(EStealthMode)CConversion.ParseIntInRange(value, 0, 3, (int)this.eSTEALTH[4]);
				break;
			case "TaikoRandom1P":
			case "TaikoRandom":
				this.eRandom[0] =
					(ERandomMode)CConversion.ParseIntInRange(value, 0, 4, (int)this.eRandom[0]);
				break;
			case "TaikoRandom2P":
				this.eRandom[1] =
					(ERandomMode)CConversion.ParseIntInRange(value, 0, 4, (int)this.eRandom[1]);
				break;
			case "TaikoRandom3P":
				this.eRandom[2] =
					(ERandomMode)CConversion.ParseIntInRange(value, 0, 4, (int)this.eRandom[2]);
				break;
			case "TaikoRandom4P":
				this.eRandom[3] =
					(ERandomMode)CConversion.ParseIntInRange(value, 0, 4, (int)this.eRandom[3]);
				break;
			case "TaikoRandom5P":
				this.eRandom[4] =
					(ERandomMode)CConversion.ParseIntInRange(value, 0, 4, (int)this.eRandom[4]);
				break;
			case "PlaySpeed":
				this.nSongSpeed =
					CConversion.ParseIntInRange(value, 5, 400, this.nSongSpeed);
				break;
			case "PlaySpeedNotEqualOneNoSound":
				this.bNoAudioIfNot1xSpeed = CConversion.bONorOFF(value[0]);
				break;
			case "Risky":
				this.nRisky = CConversion.ParseIntInRange(value, 0, 10, this.nRisky);
				break;
			case "DrumsTight":
				this.bTight = CConversion.bONorOFF(value[0]);
				break;
			case "BranchGuide":
				this.bBranchGuide = CConversion.bONorOFF(value[0]);
				break;
			case "DefaultCourse":
				this.nDefaultCourse =
					CConversion.ParseIntInRange(value, 0, 5, this.nDefaultCourse);
				break;
			case "ScoreMode":
				this.nScoreMode = CConversion.ParseIntInRange(value, 0, 3, this.nScoreMode);
				break;
			case "HispeedRandom":
				this.bHispeedRandom = CConversion.bONorOFF(value[0]);
				break;
			case "BigNotesWaitTime":
				this.nBigNoteWaitTimems =
					CConversion.ParseIntInRange(value, 1, 100, this.nBigNoteWaitTimems);
				break;
			case "BigNotesJudge":
				this.bJudgeBigNotes = CConversion.bONorOFF(value[0]);
				break;
			case "ForceNormalGauge":
				this.bForceNormalGauge = CConversion.bONorOFF(value[0]);
				break;
			case "BranchAnime":
				this.nBranchAnime =
					CConversion.ParseIntInRange(value, 0, 1, this.nBranchAnime);
				break;
			case "NoInfo":
				this.bNoInfo = CConversion.bONorOFF(value[0]);
				break;
			case "DefaultSongSort":
				this.nDefaultSongSort =
					CConversion.ParseIntInRange(value, 0, 2, this.nDefaultSongSort);
				break;
			case "RecentlyPlayedMax":
				this.nRecentlyPlayedMax =
					CConversion.ParseIntInRange(value, 0, 9999, this.nRecentlyPlayedMax);
				break;
			case "GameMode":
				this.eGameMode =
					(EGame)CConversion.ParseIntInRange(value, 0, 2, (int)this.eGameMode);
				break;
			case "TokkunSkipMeasures":
				this.TokkunSkipMeasures =
					CConversion.ParseIntInRange(value, 0, 9999, this.TokkunSkipMeasures);
				break;
			case nameof(this.TokkunMashInterval):
				this.TokkunMashInterval =
					CConversion.ParseIntInRange(value, 0, 9999, this.TokkunMashInterval);
				break;
			case "JudgeCountDisplay":
				this.bJudgeCountDisplay = CConversion.bONorOFF(value[0]);
				break;
			case "ShowExExtraAnime":
				this.ShowExExtraAnime = CConversion.bONorOFF(value[0]);
				break;
			case "PlayerCount":
				this.nPlayerCount =
					CConversion.ParseIntInRange(value, 1, 5, this.nPlayerCount);
				break;
			case nameof(this.ShinuchiMode):
				this.ShinuchiMode = CConversion.bONorOFF(value[0]);
				break;
		}
	}

	private void ProcessViewerOptionSection(string key, string value) {
		switch (key) {
			case "ViewerVSyncWait":
				this.bViewerVSyncWait = CConversion.bONorOFF(value[0]);
				break;
			case "ViewerShowDebugStatus":
				this.bViewerShowDebugStatus = CConversion.bONorOFF(value[0]);
				break;
			case "ViewerTimeStretch":
				this.bViewerTimeStretch = CConversion.bONorOFF(value[0]);
				break;
			case "ViewerGuitar":
				this.bViewerGuitar有効 = CConversion.bONorOFF(value[0]);
				break;
			case "ViewerDrums":
				this.bViewerDrums有効 = CConversion.bONorOFF(value[0]);
				break;
		}
	}

	private void ProcessGuidSection(string key, string value) {
		switch (key) {
			case "JoystickID":
				this.GetJoystickID(value);
				break;
			case "GamepadID":
				this.GetGamepadID(value);
				break;
		}
	}

	private void ProcessDrumKeyAssignmentSection(string key, string value) {
		switch (key) {
			case "LeftRed":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.LeftRed);
				break;
			case "RightRed":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.RightRed);
				break;
			case "LeftBlue":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.LeftBlue);
				break;
			case "RightBlue":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.RightBlue);
				break;
			case "LeftRed2P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.LeftRed2P);
				break;
			case "RightRed2P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.RightRed2P);
				break;
			case "LeftBlue2P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.LeftBlue2P);
				break;
			case "RightBlue2P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.RightBlue2P);
				break;
			case "LeftRed3P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.LeftRed3P);
				break;
			case "RightRed3P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.RightRed3P);
				break;
			case "LeftBlue3P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.LeftBlue3P);
				break;
			case "RightBlue3P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.RightBlue3P);
				break;
			case "LeftRed4P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.LeftRed4P);
				break;
			case "RightRed4P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.RightRed4P);
				break;
			case "LeftBlue4P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.LeftBlue4P);
				break;
			case "RightBlue4P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.RightBlue4P);
				break;
			case "LeftRed5P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.LeftRed5P);
				break;
			case "RightRed5P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.RightRed5P);
				break;
			case "LeftBlue5P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.LeftBlue5P);
				break;
			case "RightBlue5P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.RightBlue5P);
				break;
			case "Clap":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.Clap);
				break;
			case "Clap2P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.Clap2P);
				break;
			case "Clap3P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.Clap3P);
				break;
			case "Clap4P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.Clap4P);
				break;
			case "Clap5P":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.Clap5P);
				break;
			case "Decide":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.Decide);
				break;
			case "Cancel":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.Cancel);
				break;
			case "LeftChange":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.LeftChange);
				break;
			case "RightChange":
				this.ReadAndSetKey(value, this.KeyAssign.Drums.RightChange);
				break;
		}
	}

	private void ProcessSystemKeyAssignmentSection(string key, string value) {
		switch (key) {
			case "Capture": {
					this.ReadAndSetKey(value, this.KeyAssign.System.Capture);
					break;
				}
			case "SongVolumeIncrease": {
					this.ReadAndSetKey(value, this.KeyAssign.System.SongVolIncrease);
					break;
				}
			case "SongVolumeDecrease": {
					this.ReadAndSetKey(value, this.KeyAssign.System.SongVolDecrease);
					break;
				}
			case "DisplayHits": {
					this.ReadAndSetKey(value, this.KeyAssign.System.DisplayHits);
					break;
				}
			case "DisplayDebug": {
					this.ReadAndSetKey(value, this.KeyAssign.System.DisplayDebug);
					break;
				}
			case "QuickConfig": {
					this.ReadAndSetKey(value, this.KeyAssign.System.QuickConfig);
					break;
				}
			case "NewHeya": {
					this.ReadAndSetKey(value, this.KeyAssign.System.NewHeya);
					break;
				}
			case "SortSongs": {
					this.ReadAndSetKey(value, this.KeyAssign.System.SortSongs);
					break;
				}
			case "ToggleAutoP1": {
					this.ReadAndSetKey(value, this.KeyAssign.System.ToggleAutoP1);
					break;
				}
			case "ToggleAutoP2": {
					this.ReadAndSetKey(value, this.KeyAssign.System.ToggleAutoP2);
					break;
				}
			case "ToggleTrainingMode": {
					this.ReadAndSetKey(value, this.KeyAssign.System.ToggleTrainingMode);
					break;
				}
			case "CycleVideoDisplayMode": {
					this.ReadAndSetKey(value, this.KeyAssign.System.CycleVideoDisplayMode);
					break;
				}
		}
	}

	private void ProcessTrainingKeyAssignmentSection(string key, string value) {
		switch (key) {
			case "TrainingIncreaseScrollSpeed": {
					this.ReadAndSetKey(value, this.KeyAssign.Drums.TrainingIncreaseScrollSpeed);
					break;
				}
			case "TrainingDecreaseScrollSpeed": {
					this.ReadAndSetKey(value, this.KeyAssign.Drums.TrainingDecreaseScrollSpeed);
					break;
				}
			case "TrainingIncreaseSongSpeed": {
					this.ReadAndSetKey(value, this.KeyAssign.Drums.TrainingIncreaseSongSpeed);
					break;
				}
			case "TrainingDecreaseSongSpeed": {
					this.ReadAndSetKey(value, this.KeyAssign.Drums.TrainingDecreaseSongSpeed);
					break;
				}
			case "TrainingToggleAuto": {
					this.ReadAndSetKey(value, this.KeyAssign.Drums.TrainingToggleAuto);
					break;
				}
			case "TrainingBranchNormal": {
					this.ReadAndSetKey(value, this.KeyAssign.Drums.TrainingBranchNormal);
					break;
				}
			case "TrainingBranchExpert": {
					this.ReadAndSetKey(value, this.KeyAssign.Drums.TrainingBranchExpert);
					break;
				}
			case "TrainingBranchMaster": {
					this.ReadAndSetKey(value, this.KeyAssign.Drums.TrainingBranchMaster);
					break;
				}
			case "TrainingPause": {
					this.ReadAndSetKey(value, this.KeyAssign.Drums.TrainingPause);
					break;
				}
			case "TrainingBookmark": {
					this.ReadAndSetKey(value, this.KeyAssign.Drums.TrainingBookmark);
					break;
				}
			case "TrainingMoveForwardMeasure": {
					this.ReadAndSetKey(value, this.KeyAssign.Drums.TrainingMoveForwardMeasure);
					break;
				}
			case "TrainingMoveBackMeasure": {
					this.ReadAndSetKey(value, this.KeyAssign.Drums.TrainingMoveBackMeasure);
					break;
				}
			case "TrainingSkipForwardMeasure": {
					this.ReadAndSetKey(value, this.KeyAssign.Drums.TrainingSkipForwardMeasure);
					break;
				}
			case "TrainingSkipBackMeasure": {
					this.ReadAndSetKey(value, this.KeyAssign.Drums.TrainingSkipBackMeasure);
					break;
				}
			case "TrainingJumpToFirstMeasure": {
					this.ReadAndSetKey(value, this.KeyAssign.Drums.TrainingJumpToFirstMeasure);
					break;
				}
			case "TrainingJumpToLastMeasure": {
					this.ReadAndSetKey(value, this.KeyAssign.Drums.TrainingJumpToLastMeasure);
					break;
				}
		}
	}

	private void ProcessDebugSection(string key, string value) {
		switch (key) {
			case "ImGui":
				this.DEBUG_bShowImgui = CConversion.bONorOFF(value[0]);
				break;
		}
	}

	#region [ private ]

	//-----------------
	private enum ESectionType {
		Unknown,
		System,
		Log,
		PlayOption,
		ViewerOption,
		AutoPlay,
		HitRange,
		GUID,
		DrumsKeyAssign,
		SystemKeyAssign,
		TrainingKeyAssign,
		DEBUG,
		Temp,
	}

	private Dictionary<ESectionType, Action<string, string>> sectionProcess = new Dictionary<ESectionType, Action<string, string>>();

	private bool _bDrumsEnabled;
	private bool _bGuitarEnabled;
	private bool bConfigIniFileExists;
	private string ConfigIniFileName;

	private void GetJoystickID(string keyDescription) {
		string[] strArray = keyDescription.Split(new char[] { ',' });
		if (strArray.Length < 2 || !int.TryParse(strArray[0], out int result) || result < 0 || result > 9) {
			return;
		}

		this.dicJoystick.Remove(result);
		this.dicJoystick.Add(result, strArray[1]);
	}

	private void GetGamepadID(string keyDescription) {
		string[] strArray = keyDescription.Split(new char[] { ',' });
		if (strArray.Length < 2 || !int.TryParse(strArray[0], out int result) || result < 0 || result > 9) {
			return;
		}

		this.dicGamepad.Remove(result);
		this.dicGamepad.Add(result, strArray[1]);
	}

	private void ClearAllKeyAssignments() {
		this.KeyAssign = new CKeyAssign();
		for (int i = 0; i <= (int)EKeyConfigPart.System; i++) {
			for (int j = 0; j < (int)EKeyConfigPad.Max; j++) {
				this.KeyAssign[i][j] = new CKeyAssign.STKEYASSIGN[16];
				for (int k = 0; k < 16; k++) {
					this.KeyAssign[i][j][k] = new CKeyAssign.STKEYASSIGN(EInputDevice.Unknown, 0, 0);
				}
			}
		}
	}

	private void WriteKeyAssignment(StreamWriter sw, CKeyAssign.STKEYASSIGN[] assign) {
		bool flag = true;
		for (int i = 0; i < 0x10; i++) {
			if (assign[i].InputDevice == EInputDevice.Unknown) {
				continue;
			}

			if (!flag) {
				sw.Write(',');
			}

			flag = false;
			switch (assign[i].InputDevice) {
				case EInputDevice.Keyboard:
					sw.Write('K');
					break;

				case EInputDevice.MIDIInput:
					sw.Write('M');
					break;

				case EInputDevice.Joypad:
					sw.Write('J');
					break;

				case EInputDevice.Gamepad:
					sw.Write('G');
					break;

				case EInputDevice.Mouse:
					sw.Write('N');
					break;
			}

			sw.Write("{0}{1}", "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring(assign[i].ID, 1),
				assign[i].Code); // #24166 2011.1.15 yyagi: to support ID > 10, change 2nd character from Decimal to 36-numeral system. (e.g. J1023 -> JA23)
		}
	}

	private void ReadAndSetKey(string keyDescription, CKeyAssign.STKEYASSIGN[] assign) {
		string[] strArray = keyDescription.Split(new char[] { ',' });
		for (int i = 0; (i < strArray.Length) && (i < 0x10); i++) {
			EInputDevice eInputDevice;
			int id;
			int code;
			string str = strArray[i].Trim().ToUpper();
			if (str.Length >= 3) {
				eInputDevice = EInputDevice.Unknown;
				switch (str[0]) {
					case 'J':
						eInputDevice = EInputDevice.Joypad;
						break;

					case 'G':
						eInputDevice = EInputDevice.Gamepad;
						break;

					case 'K':
						eInputDevice = EInputDevice.Keyboard;
						break;

					case 'L':
						continue;

					case 'M':
						eInputDevice = EInputDevice.MIDIInput;
						break;

					case 'N':
						eInputDevice = EInputDevice.Mouse;
						break;
				}
			} else {
				continue;
			}

			id = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(str[1]);
			if (((id >= 0) && int.TryParse(str.Substring(2), out code)) && ((code >= 0) && (code <= 0xff))) {
				assign[i].InputDevice = eInputDevice;
				assign[i].ID = id;
				assign[i].Code = code;
			}
		}
	}

	private void SetDefaultKeyAssignments() {
		this.ClearAllKeyAssignments();

		string strDefaultKeyAssign = @"
[DrumsKeyAssign]
LeftRed=K015
RightRed=K019
LeftBlue=K013
RightBlue=K020
LeftRed2P=K011
RightRed2P=K023
LeftBlue2P=K012
RightBlue2P=K047
LeftRed3P=
RightRed3P=
LeftBlue3P=
RightBlue3P=
LeftRed4P=
RightRed4P=
LeftBlue4P=
RightBlue4P=
LeftRed5P=
RightRed5P=
LeftBlue5P=
RightBlue5P=
Clap=K017
Clap2P=
Clap3P=
Clap4P=
Clap5P=
Decide=K015,K019
Cancel=
LeftChange=K013
RightChange=K020

[SystemKeyAssign]
Capture=K065
SongVolumeIncrease=K074
SongVolumeDecrease=K0115
DisplayHits=K057
DisplayDebug=K049
QuickConfig=K055
NewHeya=K062
SortSongs=K0126
ToggleAutoP1=K056
ToggleAutoP2=K057
ToggleTrainingMode=K060
CycleVideoDisplayMode=K058

[TrainingKeyAssign]
TrainingIncreaseScrollSpeed=K0132
TrainingDecreaseScrollSpeed=K050
TrainingIncreaseSongSpeed=K047
TrainingDecreaseSongSpeed=K012
TrainingToggleAuto=K059
TrainingBranchNormal=K01
TrainingBranchExpert=K02
TrainingBranchMaster=K03
TrainingPause=K0126,K019
TrainingBookmark=K010
TrainingMoveForwardMeasure=K0118,K020
TrainingMoveBackMeasure=K076,K013
TrainingSkipForwardMeasure=K0109
TrainingSkipBackMeasure=K0108
TrainingJumpToFirstMeasure=K070
TrainingJumpToLastMeasure=K051
";
		LoadFromString(strDefaultKeyAssign);
	}

	//-----------------

	#endregion


	public event PropertyChangedEventHandler PropertyChanged;

	private bool SetProperty<T>(ref T storage, T value, string propertyName = null) {
		if (Equals(storage, value)) {
			return false;
		}

		storage = value;
		OnPropertyChanged(propertyName);
		return true;
	}

	private void OnPropertyChanged(string propertyName) {
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
