﻿using System;
using System.Security;

namespace Exceptional.Playground.Issues
{
    public class WrongHandlingOfDelegates
    {
        public void Foo()
        {
            Bar(delegate
            {
                throw new SecurityException("Test"); // Should show no warning: Issue => when throwing in delegate no warning should be shown
            });
        }

        public void Bar(Action test)
        {
            try
            {
                test();
            }
            catch (Exception ex)
            {
                // Catch all exceptions. 
            }
        }
    }
}