using Castle.DynamicProxy;

namespace Autofac.Core.Aspects
{

    public class LoggingInterceptorAspect : BaseInterceptorAspect
    {
        public override void Intercept(IInvocation invocation)
        {
            this.Before();
            var parameters = invocation.Method.GetParameters();
            foreach (var parameter in parameters)
            {
                if (parameter.Member is null)
                    onFailure("Parameter can not be null!");
                else
                {
                    try
                    {
                        base.Intercept(invocation);
                        this.onSuccess("Employee is added.");
                    }
                    catch (Exception ex)
                    {
                        this.onException(ex);
                    }
                    finally
                    {
                        this.After();
                    }
                }
            }
        }

        public override void onSuccess(string? successMessage) => Console.WriteLine(successMessage);
        public override void onFailure(string? failureMessage) => Console.WriteLine(failureMessage);


    }
}
