using System;
using System.IO;
using System.Text;

namespace Generater.Functions
{
    public class GenerateFileBase64 : IFunctions
    {

        #region エラーコード

        /// <summary>
        /// ファイルが見つかりません。
        /// </summary>
        public const string BASE64FROMFILE_FILE_NOT_FOUND = "BASE64FROMFILE_FILE_NOT_FOUND";

        /// <summary>
        /// 例外が発生しました。
        /// </summary>
        public const string BASE64FROMFILE_EXCEPTION = "BASE64FROMFILE_EXCEPTION";

        #endregion

        #region メンバ変数

        /// <summary>
        /// ファイルパス
        /// </summary>
        private string _filePath = string.Empty;

        /// <summary>
        /// ファイルパス
        /// </summary>
        private bool _toDecode = false;

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
        /// <param name="toDecode">true:デコード処理</param>
        public GenerateFileBase64(string filePath, bool toDecode = false)
        {
            _filePath = filePath;
            _toDecode = toDecode;

            if (!File.Exists(_filePath))
            {
                throw new FunctionException(BASE64FROMFILE_FILE_NOT_FOUND, "ファイルが見つかりません。");
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
                using (var sr = new StreamReader(_filePath))
                {
                    ret = sr.ReadToEnd();
                }
            }
            else
            {
                using (var fs = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] fileBytes = new byte[fs.Length];
                    fs.Read(fileBytes, 0, fileBytes.Length);
                    ret = Convert.ToBase64String(fileBytes);
                }
            }
            return ret;
        }
    }
}
