using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class Google_Protobuf_CodedInputStream_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Google.Protobuf.CodedInputStream);
            args = new Type[]{};
            method = type.GetMethod("SkipLastField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SkipLastField_0);
            args = new Type[]{};
            method = type.GetMethod("ReadInt32", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReadInt32_1);
            args = new Type[]{};
            method = type.GetMethod("ReadString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReadString_2);
            args = new Type[]{};
            method = type.GetMethod("ReadInt64", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReadInt64_3);
            args = new Type[]{};
            method = type.GetMethod("ReadBool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReadBool_4);
            args = new Type[]{};
            method = type.GetMethod("ReadTag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReadTag_5);
            args = new Type[]{typeof(Google.Protobuf.IMessage)};
            method = type.GetMethod("ReadMessage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReadMessage_6);
            args = new Type[]{};
            method = type.GetMethod("ReadBytes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReadBytes_7);


        }


        static StackObject* SkipLastField_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Google.Protobuf.CodedInputStream instance_of_this_method = (Google.Protobuf.CodedInputStream)typeof(Google.Protobuf.CodedInputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SkipLastField();

            return __ret;
        }

        static StackObject* ReadInt32_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Google.Protobuf.CodedInputStream instance_of_this_method = (Google.Protobuf.CodedInputStream)typeof(Google.Protobuf.CodedInputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ReadInt32();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ReadString_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Google.Protobuf.CodedInputStream instance_of_this_method = (Google.Protobuf.CodedInputStream)typeof(Google.Protobuf.CodedInputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ReadString();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ReadInt64_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Google.Protobuf.CodedInputStream instance_of_this_method = (Google.Protobuf.CodedInputStream)typeof(Google.Protobuf.CodedInputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ReadInt64();

            __ret->ObjectType = ObjectTypes.Long;
            *(long*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ReadBool_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Google.Protobuf.CodedInputStream instance_of_this_method = (Google.Protobuf.CodedInputStream)typeof(Google.Protobuf.CodedInputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ReadBool();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ReadTag_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Google.Protobuf.CodedInputStream instance_of_this_method = (Google.Protobuf.CodedInputStream)typeof(Google.Protobuf.CodedInputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ReadTag();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ReadMessage_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Google.Protobuf.IMessage @builder = (Google.Protobuf.IMessage)typeof(Google.Protobuf.IMessage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Google.Protobuf.CodedInputStream instance_of_this_method = (Google.Protobuf.CodedInputStream)typeof(Google.Protobuf.CodedInputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReadMessage(@builder);

            return __ret;
        }

        static StackObject* ReadBytes_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Google.Protobuf.CodedInputStream instance_of_this_method = (Google.Protobuf.CodedInputStream)typeof(Google.Protobuf.CodedInputStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ReadBytes();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



    }
}
