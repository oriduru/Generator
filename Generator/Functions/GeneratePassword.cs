using System;
using System.Text;
using System.Web.Security;

namespace Generater.Functions
{
    /// <summary>
    /// パスワード生成クラス
    /// </summary>
    public class GeneratePassword : IFunctions
    {
        #region エラーコード

        /// <summary>
        /// 生成数が未入力です。
        /// </summary>
        public const string PASSWORD_COUNT_NOT_INPUT = "PASSWORD_COUNT_NOT_INPUT";

        /// <summary>
        /// 生成数が範囲外です。
        /// </summary>
        public const string PASSWORD_COUNT_OUT_OF_RANGE = "PASSWORD_COUNT_OUT_OF_RANGE";

        /// <summary>
        /// 長さが未入力です。
        /// </summary>
        public const string PASSWORD_LENGTH_NOT_INPUT = "PASSWORD_LENGTH_NOT_INPUT";

        /// <summary>
        /// 長さが範囲外です。
        /// </summary>
        public const string PASSWORD_LENGTH_OUT_OF_RANGE = "PASSWORD_LENGTH_OUT_OF_RANGE";

        /// <summary>
        /// 例外が発生しました。
        /// </summary>
        public const string PASSWORD_EXCEPTION = "PASSWORD_EXCEPTION";

        #endregion

        #region メンバ変数

        /// <summary>
        /// 生成する個数
        /// </summary>
        private int _count = 0;

        /// <summary>
        /// 生成するパスワードの長さ
        /// </summary>
        private int _length = 0;

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="count">生成する個数</param>
        /// <param name="length">生成するパスワードの長さ</param>
        public GeneratePassword(int count, int length)
        {
            //エラーチェック
            if (count < 0)
            {
                throw new FunctionException(PASSWORD_COUNT_NOT_INPUT, "生成数を入力してください。");
            }

            if (count < 1 || 100 < count)
            {
                throw new FunctionException(PASSWORD_COUNT_OUT_OF_RANGE, "生成数は1～100で指定してください。");
            }

            if (length < 0)
            {
                throw new FunctionException(PASSWORD_LENGTH_NOT_INPUT, "長さを入力してください。");
            }

            if (length < 6 || 128 < length)
            {
                throw new FunctionException(PASSWORD_LENGTH_NOT_INPUT, "長さは6～128で指定してください。");
            }

            //メンバ変数に格納
            _count = count;
            _length = length;
        }

        /// <summary>
        /// 実行
        /// </summary>
        /// <returns>生成したパスワード</returns>
        public string Execute()
        {
            //生成
            var sb = new StringBuilder();
            for (var i = 0; i < _count; i++)
            {
                sb.Append(Membership.GeneratePassword(_length, 0));
                sb.Append(Environment.NewLine);
            }

            //返却
            return sb.ToString();
        }
    }
}
