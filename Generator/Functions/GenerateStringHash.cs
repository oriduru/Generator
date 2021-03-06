﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Generater.Functions
{
    /// <summary>
    /// ファイルハッシュ生成クラス
    /// </summary>
    public class GenerateStringHash : IFunctions
    {
        #region エラーコード

        /// <summary>
        /// ファイルが見つかりません。
        /// </summary>
        public const string FILEHASH_FILE_NOT_FOUND = "FILEHASH_FILE_NOT_FOUND";

        /// <summary>
        /// ハッシュアルゴリズムが未選択です。
        /// </summary>
        public const string FILEHASH_ALGORITHM_NOT_SELECTED = "FILEHASH_ALGORITHM_NOT_SELECTED";

        /// <summary>
        /// 例外が発生しました。
        /// </summary>
        public const string GUID_EXCEPTION = "FILEHASH_EXCEPTION";

        #endregion

        #region メンバ変数

        /// <summary>
        /// 文字列
        /// </summary>
        private string _text = string.Empty;

        /// <summary>
        /// ハッシュアルゴリズム
        /// </summary>
        private HashAlgorithm _hashAlgorithm = null;

        /// <summary>
        /// エンコード
        /// </summary>
        private Encoding _encoding = Encoding.UTF8;

        /// <summary>
        /// Base64で出力する
        /// </summary>
        private bool _expectsBase64 = false;

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="text">文字列</param>
        /// <param name="hashAlgorithm">ハッシュアルゴリズム</param>
        public GenerateStringHash(string text, HashAlgorithm hashAlgorithm, Encoding encoding = null, bool expectsBase64 = false)
        {
            //エラーチェック
            if (hashAlgorithm == null)
            {
                throw new FunctionException(FILEHASH_ALGORITHM_NOT_SELECTED, "ハッシュアルゴリズムを選択してください。");
            }

            //メンバ変数に格納
            _text = text;
            _hashAlgorithm = hashAlgorithm;
            _expectsBase64 = expectsBase64;
            if (encoding != null)
            {
                _encoding = encoding;
            }
        }

        /// <summary>
        /// 実行
        /// </summary>
        /// <returns>ハッシュ値</returns>
        public string Execute()
        {
            string ret;
            var textBytes = _encoding.GetBytes(_text);
            var hashBytes = _hashAlgorithm.ComputeHash(textBytes);

            if (_expectsBase64)
            {
                //Base64で返却
                ret = Convert.ToBase64String(hashBytes);
            }
            else
            {
                //16進数で返却
                ret = GetHashByHex(hashBytes);
            }
            return ret;
        }

        /// <summary>
        /// ハッシュ値を16進数表記で返却する
        /// </summary>
        /// <param name="hashBytes">ハッシュ値のバイト配列</param>
        /// <returns></returns>
        private string GetHashByHex(byte[] hashBytes)
        {
            var sb = new StringBuilder();
            foreach (var b in hashBytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
