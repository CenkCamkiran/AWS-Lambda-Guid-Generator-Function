using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambdaGuidGenerator;

public class Function
{
    
    public List<string> FunctionHandler(string input, ILambdaContext context)
    {
        int count = 0;

        if(!int.TryParse(input, out count))
            return new List<string>();

        List<string> result = new List<string>();
        for(int i = 1; i <= count; i++)
        {
            result.Add(Guid.NewGuid().ToString());
        }

        return result;
    }
}
