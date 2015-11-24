﻿using DatabaseBenchmark.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseBenchmark.Commands
{
    /// <summary>
    /// Provides an abstract description of a test command. A test command can be any class
    /// that controls the behaviour of the tests.
    /// </summary>
    public abstract class TestCommand
    {
        /// <summary>
        /// The main application form.
        /// </summary>
        public MainForm Form;

        /// <summary>
        /// The databases used to perform the tests.
        /// </summary>
        public Database[] TestedDatabases { get; set; }
        public ITest[] Tests { get; set; }

        public TestCommand(MainForm form, Database[] databases, ITest[] tests)
        {
            Form = form;

            TestedDatabases = databases;
            Tests = tests;
        }

        /// <summary>
        /// Start the execution of the command.
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// Stop the execution of the command.
        /// </summary>
        public abstract void Stop();
    }
}