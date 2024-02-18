namespace WebDepo.Helper
{
    public class Helper
    {
        public static bool ReturnValueControl(ReturnType returnType)
        {
			try
			{
				if (returnType.Status != StatusCode.Success)
				{
					return false;
				}
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
        }
    }
}
