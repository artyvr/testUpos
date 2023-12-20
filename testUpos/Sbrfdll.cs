using System;
using System.Collections.Generic;

namespace testUpos
{
    public static class Sbrfdll
    {
        public const string NotRegSbrfDllErrorMsg = "sbrf.dll не зарегистрирована!";
        public const string SbrfDllServer = "SBRFSRV.Server";

        static Dictionary<string, dynamic> operationResult = new Dictionary<string, dynamic>();

        public static dynamic CreateOblectSbrf()
        {
            try
            {
                return Activator.CreateInstance(Type.GetTypeFromProgID(SbrfDllServer));
            }
            catch (ArgumentException)
            {
                throw new ArgumentException(NotRegSbrfDllErrorMsg);
            }
        }

        public static Dictionary<string, dynamic> GetResult(int i, dynamic d)
        {
            operationResult.Clear();
            operationResult.Add("resultCode", i);
            operationResult.Add("resultCheque", d);
            return operationResult;
        }

        public static Dictionary<string, dynamic> GetTID()
        {
            dynamic srv = CreateOblectSbrf();
            srv.Clear();
            srv.SParam("Dirgate", $"{TestUposForm.dllPath}\\");
            return GetResult(srv.NFun(15), srv.GParamString("TermNum"));
        }

        public static Dictionary<string, dynamic> TestPinPadConnection()
        {
            dynamic srv = CreateOblectSbrf();
            srv.Clear();
            return GetResult(srv.NFun(13), srv.GParamString("Cheque1251"));
        }

        public static Dictionary<string, dynamic> GetAmount()
        {
            dynamic srv = CreateOblectSbrf();
            srv.Clear();
            srv.SParam("Amount", 100);
            return GetResult(srv.NFun(4000), srv.GParamString("Cheque1251"));
        }

        public static Dictionary<string, dynamic> RollBackAmount()
        {
            dynamic srv = CreateOblectSbrf();
            srv.Clear();
            srv.SParam("Amount", 100);
            return GetResult(srv.NFun(4002), srv.GParamString("Cheque1251"));
        }

        public static Dictionary<string, dynamic> CloseDay()
        {
            dynamic srv = CreateOblectSbrf();
            srv.Clear();
            return GetResult(srv.NFun(6000), srv.GParamString("Cheque1251"));
        }
    }
}
