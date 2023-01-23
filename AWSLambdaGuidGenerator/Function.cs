using Amazon.Lambda.Core;
using Models;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambdaGuidGenerator;

public class Function
{
    public ResponseModel FunctionHandler(RequestModel input, ILambdaContext context)
    {

        if(input.Count == null)
            return new ResponseModel()
            {
                ErrorCode = 400,
                ErrorMessage = "Count property in the body should not be empty or null!",
            };

        List<string> list = new List<string>();
        for (int i = 1; i <= input.Count; i++)
        {
            list.Add(Guid.NewGuid().ToString());
        }

        return new ResponseModel()
        {
            ResponseCode= 200,
            ResponseMessage = "OK", 
            GuidList = list
        };

    }
}
