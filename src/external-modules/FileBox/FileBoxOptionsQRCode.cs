﻿
namespace Wechaty
{
    public class FileBoxOptionsQRCode : FileBoxOptions
    {
        public override FileBoxType Type => FileBoxType.QRCode;
        public string QrCode { get; set; }
    }
}
