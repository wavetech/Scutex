using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Scutex Licensing")]
[assembly: AssemblyDescription("Scutex Licensing System")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("WaveTech Digital Technologies, Inc.")]
[assembly: AssemblyProduct("Scutex")]
[assembly: AssemblyCopyright("Copyright © WaveTech Digital Technologies, Inc. 2009-2011")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en-US")]

[assembly: InternalsVisibleTo("WaveTech.Scutex.UnitTests, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("Scutex.TestProject, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.TestHarness, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]

[assembly: InternalsVisibleTo("ScutexLicensingCCW, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Licensing, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Services, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Framework, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("LicensingManager, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Licensing, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Repositories.ClientDataRepository, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Repositories.ManagerDataRepository, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Repositories.ServicesDataRepository, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Providers.AsymmetricEncryptionProvider, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Providers.CompressionProvider, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Providers.DatabaseUpdateProvider, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Providers.DataGenerationProvider, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Providers.HashingProvider, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Providers.NetworkTimeProvider, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Providers.ObjectSerializationProvider, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Providers.SymmetricEncryptionProvider, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Providers.WebServicesProvider, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.Providers.WmiDataProvider, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.WcfServices.ServicesLibrary, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]
[assembly: InternalsVisibleTo("WaveTech.Scutex.FingerprintViewer, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]


[assembly: InternalsVisibleTo("StructureMap, PublicKey=00240000048000009400000006020000002400005253413100040000010001009fed293ec2e3172bb8457de6c3dca8b58b57a28fc32743fbe39399806dd4c8c483579aa1b90da70db3b3f850b665ca18a536809654b1bbc651360f4b18166baf56428e9f9a0d89adbb8ec3b32e3f5503f3c3ac37ac0ac4a033ed4b6429b02c03f6a98b56b33e89ca702b9268d47f2b24323e98abb57d66703fe9d424b477aa89")]



// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("888a65a9-57e1-4653-9a7e-47277283938c")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("0.4.1202.2207")]	// Rule: *.*.YYMM.DDhh
[assembly: AssemblyFileVersion("0.4.1202.2207")]	// Rule: *.*.YYMM.DDhh
