﻿using System;

namespace Hangfire.MissionControl.Tests.Web
{
    [MissionLauncher(CategoryName = "Primitives")]
    public class TestSuite
    {
        [Mission]
        public string DoJob(string name) => "success";

        [Mission]
        public string DoJob(bool isChecked) => "success";

        [Mission]
        public string DoJob(byte byteValue) => "success";

        [Mission]
        public string DoJob(int  intValue) => "success";

        [Mission]
        public string DoJob(long longValue) => "success";

        [Mission]
        public string DoJob(float floatValue) => "success";

        [Mission]
        public string DoJob(double doubleValue) => "success";

        [Mission]
        public string DoJob(DateTime dataTime) => "success";
    }

    [MissionLauncher(CategoryName = "Descriptions")]
    public class TestSuite2
    {
        [Mission(Name = "Mission #1")]
        public string DoJob(int id, DateTime time) => "success";

        [Mission(Name = "Mission #2", Description = "This is very important mission")]
        public static string DoAnotherJob(double value) => "success2";
    }

    [MissionLauncher(CategoryName = "Queueing")]
    public static class TestSuite3
    {
        [Mission(Name = "Mission #3", Description = "Mission with specified queue", Queue = "queue1")]
        public static string DoJob(int id, DateTime time) => "success";
    }
}