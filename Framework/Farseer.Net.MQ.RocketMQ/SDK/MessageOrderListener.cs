//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Farseer.Net.MQ.RocketMQ.SDK
{
    public class MessageOrderListener : IDisposable
    {
        private HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal MessageOrderListener(IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new HandleRef(this, cPtr);
        }

        internal static HandleRef getCPtr(MessageOrderListener obj) { return obj == null ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr; }

        ~MessageOrderListener() { Dispose(); }

        public virtual void Dispose()
        {
            lock (this)
            {
                if (swigCPtr.Handle != IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        ONSClient4CPPPINVOKE.delete_MessageOrderListener(swigCPtr);
                    }
                    swigCPtr = new HandleRef(null, IntPtr.Zero);
                }
                GC.SuppressFinalize(this);
            }
        }

        public MessageOrderListener() : this(ONSClient4CPPPINVOKE.new_MessageOrderListener(), true) { SwigDirectorConnect(); }

        public virtual OrderAction consume(Message message, ConsumeOrderContext context)
        {
            var ret = (OrderAction)ONSClient4CPPPINVOKE.MessageOrderListener_consume(swigCPtr, Message.getCPtr(message), ConsumeOrderContext.getCPtr(context));
            if (ONSClient4CPPPINVOKE.SWIGPendingException.Pending) throw ONSClient4CPPPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private void SwigDirectorConnect()
        {
            if (SwigDerivedClassHasMethod("consume", swigMethodTypes0)) swigDelegate0 = SwigDirectorconsume;
            ONSClient4CPPPINVOKE.MessageOrderListener_director_connect(swigCPtr, swigDelegate0);
        }

        private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
        {
            var methodInfo = GetType().GetMethod(methodName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null, methodTypes, null);
            var hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(MessageOrderListener));
            return hasDerivedMethod;
        }

        private int SwigDirectorconsume(IntPtr message, IntPtr context) { return (int)consume(new Message(message, false), new ConsumeOrderContext(context, false)); }

        public delegate int SwigDelegateMessageOrderListener_0(IntPtr message, IntPtr context);

        private SwigDelegateMessageOrderListener_0 swigDelegate0;

        private static readonly Type[] swigMethodTypes0 = {typeof(Message), typeof(ConsumeOrderContext)};
    }
}