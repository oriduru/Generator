using System;

namespace Generater.Functions
{
    /// <summary>
    /// 機能クラス用例外
    /// </summary>
    public class FunctionException : Exception
    {
        #region プロパティ

        /// <summary>
        /// エラーコード
        /// </summary>
        public string ErrorCode { get; private set; }

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="errorCode">エラーコード</param>
        /// <param name="errorMessage">エラーメッセージ</param>
        /// <param name="innerException">内部例外</param>
        public FunctionException(string errorCode, string errorMessage, Exception innerException = null)
            : base(errorMessage ?? string.Empty, innerException)
        {
            ErrorCode = errorCode;
        }
    }
}
