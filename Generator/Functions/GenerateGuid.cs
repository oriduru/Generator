using System;
using System.Text;

namespace Generater.Functions
{
    /// <summary>
    /// パスワード生成クラス
    /// </summary>
    public class GenerateGuid : IFunctions
    {
        #region エラーコード

        /// <summary>
        /// 生成数が未入力です。
        /// </summary>
        public const string GUID_COUNT_NOT_INPUT = "GUID_COUNT_NOT_INPUT";

        /// <summary>
        /// 生成数が範囲外です。
        /// </summary>
        public const string GUID_COUNT_OUT_OF_RANGE = "GUID_COUNT_OUT_OF_RANGE";

        /// <summary>
        /// 例外が発生しました。
        /// </summary>
        public const string GUID_EXCEPTION = "GUID_EXCEPTION";

        #endregion

        #region メンバ変数

        /// <summary>
        /// 生成する個数
        /// </summary>
        private int _count = 0;

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="count">生成する個数</param>
        public GenerateGuid(int count)
        {
            //エラーチェック
            if (count < 0)
            {
                throw new FunctionException(GUID_COUNT_NOT_INPUT, "生成数を入力してください。");
            }

            if (count < 1 || 10000 < count)
            {
                throw new FunctionException(GUID_COUNT_OUT_OF_RANGE, "生成数は0～10,000で指定してください。");
            }

            //メンバ変数に格納
            _count = count;
        }

        /// <summary>
        /// 実行
        /// </summary>
        /// <returns>生成したGUID</returns>
        public string Execute()
        {
            //生成
            var sb = new StringBuilder();
            for (var i = 0; i < _count; i++)
            {
                sb.Append(Guid.NewGuid().ToString());
                sb.Append(Environment.NewLine);
            }

            //返却
            return sb.ToString();
        }
    }
}
