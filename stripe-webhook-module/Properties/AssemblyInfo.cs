﻿using stripe_webhook_module;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Web;

[assembly: AssemblyTitle("stripe-webhook-module")]
[assembly: AssemblyDescription("stripe.com webhook httpmodule")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Bates Westmoreland")]
[assembly: AssemblyProduct("stripe-webhook-module")]
[assembly: AssemblyCopyright("Copyright © Bates Westmoreland 2012")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("ba61b46d-b088-4b14-9fa0-c3aac6d8d99f")]

[assembly: AssemblyVersion("1.0.0")]
[assembly: AssemblyFileVersion("1.0.0")]

[assembly: PreApplicationStartMethod(typeof(StripeWebhookModuleLoader), "Load")]
