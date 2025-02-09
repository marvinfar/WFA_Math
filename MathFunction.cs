using System;
using System.Activities;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;

namespace WFA_Math
{
    public class Sum : CodeActivity
    {
        [RequiredArgument]
        [Input("Num1")]
        public InArgument<double> Number1 { get; set; }

        [RequiredArgument]
        [Input("Num2")]
        public InArgument<double> Number2 { get; set; }

        [Output("SumOf")]
        public OutArgument<decimal> SumOf { get; set; }
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);
            //
            var num1= Number1.Get(executionContext);
            var num2 = Number2.Get(executionContext);
            try
            {
                SumOf.Set(executionContext, Convert.ToDecimal(num1 + num2));
            }
            catch 
            {
                SumOf.Set(executionContext, Convert.ToDecimal(0));
            }
        }

    }
    public class Sub : CodeActivity
    {
        [RequiredArgument]
        [Input("Num1")]
        public InArgument<double> Number1 { get; set; }

        [RequiredArgument]
        [Input("Num2")]
        public InArgument<double> Number2 { get; set; }

        [Output("Subtraction")]
        public OutArgument<decimal> Subtraction { get; set; }
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);
            //
            var num1 = Number1.Get(executionContext);
            var num2 = Number2.Get(executionContext);
            try
            {
                Subtraction.Set(executionContext, Convert.ToDecimal(num1 - num2));
            }
            catch 
            {
                Subtraction.Set(executionContext, Convert.ToDecimal(0));
            }
        }

    }
    public class Mult : CodeActivity
    {
        [RequiredArgument]
        [Input("Num1")]
        public InArgument<double> Number1 { get; set; }

        [RequiredArgument]
        [Input("Num2")]
        public InArgument<double> Number2 { get; set; }

        [Output("Multiply")]
        public OutArgument<decimal> Multiply { get; set; }
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);
            //
            var num1 = Number1.Get(executionContext);
            var num2 = Number2.Get(executionContext);
            try
            {
                Multiply.Set(executionContext, Convert.ToDecimal(num1 * num2));
            }
            catch
            {
                Multiply.Set(executionContext, Convert.ToDecimal(0));
            }
        }

    }
    public class Div : CodeActivity
    {
        [RequiredArgument]
        [Input("Num1")]
        public InArgument<double> Number1 { get; set; }

        [RequiredArgument]
        [Input("Num2")]
        public InArgument<double> Number2 { get; set; }

        [Output("Division")]
        public OutArgument<decimal> Division { get; set; }
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);
            //
            var num1 = Number1.Get(executionContext);
            var num2 = Number2.Get(executionContext);
            try
            {
                if (num2!=0)
                    Division.Set(executionContext, Convert.ToDecimal(num1 / num2));
                else
                    Division.Set(executionContext,0);
            }
            catch 
            {
                Division.Set(executionContext, 0);
            }
        }

    }
    public class Pow : CodeActivity
    {
        [RequiredArgument]
        [Input("Num1")]
        public InArgument<double> Number1 { get; set; }

        [RequiredArgument]
        [Input("Num2")]
        public InArgument<double> Number2 { get; set; }

        [Output("Power")]
        public OutArgument<decimal> Power { get; set; }
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);
            //
            var num1 = Number1.Get(executionContext);
            var num2 = Number2.Get(executionContext);
            try
            {
                var p = 1.0;
                for (int i = 1; i <= num2; i++)
                {
                    p *= num1;
                }
                Power.Set(executionContext, Convert.ToDecimal(p));
            }
            catch 
            {
                Power.Set(executionContext, Convert.ToDecimal(0));
            }
        }

    }
    public class Abs : CodeActivity
    {
        [RequiredArgument]
        [Input("Num1")]
        public InArgument<double> Number1 { get; set; }

        [Output("Absolute")]
        public OutArgument<decimal> Absolute { get; set; }
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);
            //
            var num1 = Number1.Get(executionContext);
            try
            {
                Absolute.Set(executionContext,num1<0 ?-num1:num1);
            }
            catch 
            {
                Absolute.Set(executionContext, 0);
            }
        }

    }
    public class ToInteger : CodeActivity
    {
        [RequiredArgument]
        [Input("Text")]
        public InArgument<string> Text { get; set; }

        [Output("Output")]
        public OutArgument<int> Output { get; set; }
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);
            //
            var txt = Text.Get(executionContext).ToString().Trim();
            try
            {
               Output.Set(executionContext, txt.Length > 0 ? Int32.Parse(txt) : 0);   
            }
            catch 
            {
                Output.Set(executionContext, 0);
            }
        }

    }
    public class ToCurrency : CodeActivity
    {
        [RequiredArgument]
        [Input("Text")]
        public InArgument<string> Text { get; set; }

        [Output("Output")]
        public OutArgument<decimal> Output { get; set; }
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);
            //
            var txt = Text.Get(executionContext).ToString().Trim().Replace(",","");
            try
            {
                Output.Set(executionContext, txt.Length > 0 ? decimal.Parse(txt) : 0);
            }
            catch 
            {
                Output.Set(executionContext, 0);
            }
        }

    }
    public class IsNumber : CodeActivity
    {
        [RequiredArgument]
        [Input("String")]
        public InArgument<string> StringText { get; set; }

        [Output("isNumber")]
        public OutArgument<bool> isNumber { get; set; }
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);
            //
            var txt = StringText.Get(executionContext).Trim();
            try
            {
                if (txt.Length > 0)
                {
                    bool containsAlphabet = txt.Any(char.IsLetter);
                    if (containsAlphabet)
                        isNumber.Set(executionContext, false);
                    else
                        isNumber.Set(executionContext, true);
                }
            }
            catch 
            {
                isNumber.Set(executionContext, false);
            }
        }

    }
    public class EvaluateExpression : CodeActivity
    {

        [RequiredArgument]
        [Input("Text")]
        public InArgument<string> Text { get; set; }

        [Output("Output")]
        public OutArgument<double> Output { get; set; }
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);
            //
            var txt = Text.Get(executionContext).Trim();
            try
            {
                if (txt.Length > 0)
                {
                    txt = txt.Replace(",","" ).Replace("ريال","").Replace("تومان","").Replace("$", "").Trim();
                    DataTable table = new DataTable();
                    Output.Set(executionContext, Convert.ToDouble(table.Compute(txt, string.Empty)));
                }
            }
            catch 
            {
                Output.Set(executionContext, Convert.ToDouble(0));
            }
            //aaa
        }

    }
    public class Round : CodeActivity
    {
        [RequiredArgument]
        [Input("Num")]
        public InArgument<double> Number { get; set; }

        [Output("Rounded")]
        public OutArgument<double> Rounded { get; set; }
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);
            //
            var num = Number.Get(executionContext);
            try
            {
                Rounded.Set(executionContext, Convert.ToDouble(Math.Round(num)));
            }
            catch
            {
                Rounded.Set(executionContext, Convert.ToDouble(0));
            }
        }

    }
    public class Ceil : CodeActivity
    {
        [RequiredArgument]
        [Input("Num")]
        public InArgument<double> Number { get; set; }

        [Output("Ceiled")]
        public OutArgument<double> Ceiled { get; set; }
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);
            //
            var num = Number.Get(executionContext);
            try
            {
                Ceiled.Set(executionContext, Convert.ToDouble(Math.Ceiling(num)));
            }
            catch
            {
                Ceiled.Set(executionContext, Convert.ToDouble(0));
            }
        }

    }
    public class Truncate : CodeActivity
    {
        [RequiredArgument]
        [Input("Num")]
        public InArgument<double> Number { get; set; }

        [Output("Truncated")]
        public OutArgument<double> Truncated { get; set; }
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);
            //
            var num = Number.Get(executionContext);
            try
            {
                Truncated.Set(executionContext, Convert.ToDouble(Math.Truncate(num)));
            }
            catch
            {
                Truncated.Set(executionContext, Convert.ToDouble(0));
            }
        }

    }
    public class Floor : CodeActivity
    {
        [RequiredArgument]
        [Input("Num")]
        public InArgument<double> Number { get; set; }

        [Output("Floored")]
        public OutArgument<double> Floored { get; set; }
        protected override void Execute(CodeActivityContext executionContext)
        {
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);
            //
            var num = Number.Get<double>(executionContext);
            try
            {
                Floored.Set(executionContext, Convert.ToDouble(Math.Floor(num)));
            }
            catch
            {
                Floored.Set(executionContext, Convert.ToDouble(0));
            }
        }

    }
}
