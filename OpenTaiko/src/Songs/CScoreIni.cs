﻿namespace OpenTaiko {
	[Serializable]
	public class CScoreIni {
		// プロパティ

		[Serializable]
		public class C演奏記録 {
			public int nOkCount;
			public int nBadCount;
			public int nGoodCount;
			public Dan_C[] Dan_C;

			public C演奏記録() {
				Dan_C = new Dan_C[CExamInfo.cMaxExam];
			}

		}

	}
}
