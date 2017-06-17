using System;
using System.Text;

namespace Generater.Functions
{
    public class GenerateStringBase64 : IFunctions
    {

        #region エラーコード

        /// <summary>
        /// ファイルが見つかりません。
        /// </summary>
        public const string BASE64FROMSTRING_FILE_NOT_FOUND = "BASE64FROMSTRING_FILE_NOT_FOUND";

        /// <summary>
        /// 例外が発生しました。
        /// </summary>
        public const string BASE64FROMSTRING_EXCEPTION = "BASE64FROMSTRING_EXCEPTION";

        #endregion

        #region メンバ変数

        /// <summary>
        /// 変換対象文字列
        /// </summary>
        private string _text = string.Empty;

        /// <summary>
        /// デコードする
        /// </summary>
        private bool _toDecode = false;

        /// <summary>
        /// エンコード
        /// </summary>
        private Encoding _encoding = Encoding.UTF8;

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="text">変換対象文字列</param>
        /// <param name="toDecode">デコードする</param>
        /// <param name="encoding">エンコーディング</param>
        public GenerateStringBase64(string text, bool toDecode = false, Encoding encoding = null)
        {
            _text = text;
            _toDecode = toDecode;
            if (encoding != null)
            {
                _encoding = encoding;
            }
        }

        /// <summary>
        /// 実行
        /// </summary>
        /// <returns>Base64文字列</returns>
        public string Execute()
        {
            string ret;
            if (_toDecode)
            {
                ret = GetPlainText();
            }
            else
            {
                ret = Convert.ToBase64String(_encoding.GetBytes(_text));
            }
            return ret;
        }

        /// <summary>
        /// Base64を変換しプレーンテキストを取得する
        /// </summary>
        /// <returns>プレーンテキスト</returns>
        private string GetPlainText()
        {
            string ret;
            try
            {
                ret = _encoding.GetString(Convert.FromBase64String(_text));
            }
            catch
            {
                ret = string.Empty;
            }
            return ret;
        }
    }
}
