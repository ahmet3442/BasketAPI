using System;

namespace Core.Common.Service
{
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "response")]
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public string ErrorCode { get; set; }
        public string Message { get; set; } = "İşlem başarılıdır.";
        public Guid RequestId { get; set; } = Guid.NewGuid();
        public object Data { get; set; }
    }
    
}