﻿//HintName: Splat.DI.Extensions.Registrations.SourceGenerated.cs

// <auto-generated />
namespace Splat
{
    internal static partial class SplatRegistrations
    {
        static partial void SetupIOCInternal()
        {
            Splat.Locator.CurrentMutable.Register(() => new global::Test.TestConcrete((global::Test.IService1)Splat.Locator.Current.GetService(typeof(global::Test.IService1)), (global::Test.IService2)Splat.Locator.Current.GetService(typeof(global::Test.IService2))){ ServiceProperty=(global::Test.IServiceProperty)Splat.Locator.Current.GetService(typeof(global::Test.IServiceProperty))} , typeof(global::Test.ITest), "Test1");
        }
    }
}