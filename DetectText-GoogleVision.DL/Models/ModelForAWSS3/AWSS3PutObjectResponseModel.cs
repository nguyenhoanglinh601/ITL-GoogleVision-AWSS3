using System;
using System.Collections.Generic;
using System.Text;
using DetectText_GoogleVision.Service.Models.ModelForAWSS3;

namespace DetectText_GoogleVision.DL.Models.ModelForAWSS3
{
    public class AWSS3PutObjectResponseModel: AWSS3PutObjectResponse
    {
        public CsDocumentModel Document { get; set; }
    }
}
