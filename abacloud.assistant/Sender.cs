using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Abacloud.ApiClient;

namespace abacloud.assistant
{
    class Sender
    {
        private readonly Client client = Client.Create("http://127.0.0.1:5001/", "user", "pass");

        public string SendFile(string a_fileName)
        {
            string _retVal;

            var _stream = File.Open(a_fileName, FileMode.Open, FileAccess.Read);
            string _errorMessage;
            _retVal = client.SendContent(_stream, out _errorMessage);
            if (string.IsNullOrEmpty(_retVal))
            {
                throw new Exception(_errorMessage);
            }
            _stream.Close();

            return _retVal;
        }

        public Dictionary<string,string> SendDirectory(string a_path)
        {
            if (!Directory.Exists(a_path))
                throw new DirectoryNotFoundException(string.Format("Не найден каталог для отправки {0}", a_path));
            
            var _retDic = new Dictionary<string, string>();

            var _directoryInfo = new DirectoryInfo(a_path);
            foreach (var _fileInfo in _directoryInfo.GetFiles())
            {
                var _fileName = _fileInfo.FullName;
                var _guid = SendFile(_fileName);
                _retDic.Add(_fileName,_guid);
            }
            foreach (var _directory in _directoryInfo.GetDirectories())
            {
                var _dic = SendDirectory(_directory.FullName);
                foreach (var _rec in _dic)
                {
                    _retDic.Add(_rec.Key, _rec.Value);
                }
            }

            return _retDic;
        }
    }
}
