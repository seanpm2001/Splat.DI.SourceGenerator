﻿//HintName: Splat.DI.Extensions.Registrations.SourceGenerated.cs

// <auto-generated />
namespace Splat
{
    internal static partial class SplatRegistrations
    {
        static partial void SetupIOCInternal()
        {
            {
                global::System.Lazy<Test.ITest> lazy = new global::System.Lazy<Test.ITest>(() => new global::Test.TestConcrete());
                Splat.Locator.CurrentMutable.Register(() => lazy, typeof(global::System.Lazy<Test.ITest>));
                Splat.Locator.CurrentMutable.Register(() => lazy.Value, typeof(global::Test.ITest));
            }
        }
    }
}