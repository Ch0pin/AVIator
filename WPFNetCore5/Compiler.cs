using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Text;


namespace AvIator
{
    class Compiler
    {
        CSharpCodeProvider provider = new CSharpCodeProvider();
        CompilerParameters parameters = new CompilerParameters();

        public Compiler()
        {
            
            parameters.ReferencedAssemblies.Add("System.Core.dll");
            parameters.GenerateInMemory = false;
            parameters.GenerateExecutable = true;
            parameters.IncludeDebugInformation = false;
            parameters.ReferencedAssemblies.Add("mscorlib.dll");
            parameters.ReferencedAssemblies.Add("System.dll");
            

        }
        public void compileToExe(String code, String decKey,String filePath, String Arch)
        {
            parameters.OutputAssembly = filePath;
            parameters.CompilerOptions = "/target:exe" + Arch;
            
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, code);

            if (results.Errors.HasErrors)
            {
                StringBuilder sb = new StringBuilder();

                foreach (CompilerError error in results.Errors)
                {
                    sb.AppendLine(String.Format("Error ({0}): {1}", error.ErrorNumber, error.ErrorText));
                }

                throw new InvalidOperationException(sb.ToString());
            }
        }

    }
}
