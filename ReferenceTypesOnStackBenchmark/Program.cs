using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess;
using ReferenceTypesInStack;

namespace ReferenceTypesOnStackBenchmark
{
    [ClrJob, CoreJob]
    [RPlotExporter, RankColumn]
    public class StackTesting
    {
        [Params(10000, 100000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
        }

        [Benchmark]
        public StackReferenceType Heap() => new StackReferenceType();

        [Benchmark]
        public unsafe StackReferenceType Md5()
        {
            int* pointer = stackalloc int[2];
            return StackInitializer.InitializeOnStack<StackReferenceType>(pointer);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunnerCore.Run(BenchmarkConverter.TypeToBenchmarks(typeof(StackTesting)), t => InProcessToolchain.Instance);
            Console.Read();
        }
    }
}
