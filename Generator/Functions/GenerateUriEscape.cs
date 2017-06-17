using System;
using System.Web;

namespace Generater.Functions
{
    /// <summary>
    /// パスワード生成クラス
    /// </summary>
    public class GenerateUriEscape : IFunctions
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
        /// 変換対象文字列
        /// </summary>
        private string _text = string.Empty;

        /// <summary>
        /// RFC3986に従ったエンコードを行う
        /// </summary>
        private bool _basedOnRFC3986 = false;

        /// <summary>
        /// デコードする
        /// </summary>
        private bool _toDecode = false;
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="text">変換対象文字列</param>
        /// <param name="basedOnRFC3986">RFC3986に従ったエンコードを行う</param>
        public GenerateUriEscape(string text, bool basedOnRFC3986, bool toDecode = false)
        {
            _text = text;
            _basedOnRFC3986 = basedOnRFC3986;
            _toDecode = toDecode;
        }

        /// <summary>
        /// 実行
        /// </summary>
        /// <returns>変換後のテキスト</returns>
        public string Execute()
        {
            string ret;
            if (_toDecode)
            {
                //デコード
                ret = HttpUtility.UrlDecode(_text);
            }
            else
            {
                //エンコード
                if (_basedOnRFC3986)
                {
                    ret = Uri.EscapeDataString(_text);
                }
                else
                {
                    ret = Uri.EscapeUriString(_text);
                }
            }
            return ret;
        }
    }
}
