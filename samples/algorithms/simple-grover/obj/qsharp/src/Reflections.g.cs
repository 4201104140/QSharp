//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"ReflectAboutMarked\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Reflects about the basis state marked by alternating zeros and ones.\",\" This operation defines what input we are trying to find in the main\",\" search.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"ReflectAboutMarked\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"ReflectAboutUniform\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":35,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Reflects about the uniform superposition state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"ReflectAboutUniform\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":35,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"ReflectAboutAllOnes\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":51,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Reflects about the all-ones state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"ReflectAboutAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":51,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareUniform\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Given a register in the all-zeros state, prepares a uniform\",\" superposition over all basis states.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareUniform\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareUniform\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Microsoft.Quantum.Samples.SimpleGrover.PrepareUniform\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareUniform\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlled specialization for Microsoft.Quantum.Samples.SimpleGrover.PrepareUniform\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareUniform\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Microsoft.Quantum.Samples.SimpleGrover.PrepareUniform\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareAllOnes\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":65,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Given a register in the all-zeros state, prepares an all-ones state\",\" by flipping every qubit.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":65,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":65,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Microsoft.Quantum.Samples.SimpleGrover.PrepareAllOnes\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":65,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlled specialization for Microsoft.Quantum.Samples.SimpleGrover.PrepareAllOnes\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.SimpleGrover\",\"Name\":\"PrepareAllOnes\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\simple-grover\\\\Reflections.qs\",\"Position\":{\"Item1\":65,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Microsoft.Quantum.Samples.SimpleGrover.PrepareAllOnes\"]}")]
#line hidden
namespace Microsoft.Quantum.Samples.SimpleGrover
{
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs", OperationFunctor.Body, 16, 36)]
    public partial class ReflectAboutMarked : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public ReflectAboutMarked(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectAboutMarked";
        String ICallable.FullName => "Microsoft.Quantum.Samples.SimpleGrover.ReflectAboutMarked";
        protected ICallable<String, QVoid> Message__
        {
            get;
            set;
        }

        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected IAdjointable Microsoft__Quantum__Canon__ApplyToEachA
        {
            get;
            set;
        }

        protected ICallable Length__
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> __Body__ => (__in__) =>
        {
            var inputQubits = __in__;
#line 17 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
            Message__.Apply("Reflecting about marked state...");
#line hidden
            {
#line 18 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
                var outputQubit = Allocate__.Apply();
#line hidden
                bool __arg1__ = true;
                try
                {
#line 22 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
                    Microsoft__Quantum__Intrinsic__X.Apply(outputQubit);
#line 23 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
                    Microsoft__Quantum__Intrinsic__H.Apply(outputQubit);
#line 27 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
                    Microsoft__Quantum__Canon__ApplyToEachA.Apply((Microsoft__Quantum__Intrinsic__X, inputQubits.Slice(new QRange(((2L < 0L) ? (inputQubits.Length - 1L) : 0L), 2L, ((2L < 0L) ? 0L : (inputQubits.Length - 1L))))));
#line 29 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
                    Microsoft__Quantum__Intrinsic__X.Controlled.Apply((inputQubits, outputQubit));
#line 16 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
                    Microsoft__Quantum__Canon__ApplyToEachA.Adjoint.Apply((Microsoft__Quantum__Intrinsic__X, inputQubits.Slice(new QRange(((2L < 0L) ? (inputQubits.Length - 1L) : 0L), 2L, ((2L < 0L) ? 0L : (inputQubits.Length - 1L))))));
#line 16 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
                    Microsoft__Quantum__Intrinsic__H.Adjoint.Apply(outputQubit);
#line 16 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
                    Microsoft__Quantum__Intrinsic__X.Adjoint.Apply(outputQubit);
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(outputQubit);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Message__ = this.__Factory__.Get<ICallable<String, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Message));
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Canon__ApplyToEachA = this.__Factory__.Get<IAdjointable>(typeof(global::Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.Length__ = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __DataIn__(IQArray<Qubit> data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> inputQubits)
        {
            return __m__.Run<ReflectAboutMarked, IQArray<Qubit>, QVoid>(inputQubits);
        }
    }

    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs", OperationFunctor.Body, 36, 52)]
    public partial class ReflectAboutUniform : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public ReflectAboutUniform(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectAboutUniform";
        String ICallable.FullName => "Microsoft.Quantum.Samples.SimpleGrover.ReflectAboutUniform";
        protected IUnitary<IQArray<Qubit>> PrepareUniform__
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> PrepareAllOnes__
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> ReflectAboutAllOnes__
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> __Body__ => (__in__) =>
        {
            var inputQubits = __in__;
#line 39 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
            PrepareUniform__.Adjoint.Apply(inputQubits);
#line 41 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
            PrepareAllOnes__.Apply(inputQubits);
#line 46 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
            ReflectAboutAllOnes__.Apply(inputQubits);
#line 36 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
            PrepareAllOnes__.Adjoint.Apply(inputQubits);
#line 36 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
            PrepareUniform__.Adjoint.Adjoint.Apply(inputQubits);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.PrepareUniform__ = this.__Factory__.Get<IUnitary<IQArray<Qubit>>>(typeof(PrepareUniform));
            this.PrepareAllOnes__ = this.__Factory__.Get<IUnitary<IQArray<Qubit>>>(typeof(PrepareAllOnes));
            this.ReflectAboutAllOnes__ = this.__Factory__.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(ReflectAboutAllOnes));
        }

        public override IApplyData __DataIn__(IQArray<Qubit> data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> inputQubits)
        {
            return __m__.Run<ReflectAboutUniform, IQArray<Qubit>, QVoid>(inputQubits);
        }
    }

    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs", OperationFunctor.Body, 52, 59)]
    public partial class ReflectAboutAllOnes : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public ReflectAboutAllOnes(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectAboutAllOnes";
        String ICallable.FullName => "Microsoft.Quantum.Samples.SimpleGrover.ReflectAboutAllOnes";
        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__Z
        {
            get;
            set;
        }

        protected ICallable Microsoft__Quantum__Arrays__Most
        {
            get;
            set;
        }

        protected ICallable Microsoft__Quantum__Arrays__Tail
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> __Body__ => (__in__) =>
        {
            var inputQubits = __in__;
#line 53 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Intrinsic__Z.Controlled.Apply((Microsoft__Quantum__Arrays__Most.Apply<IQArray<Qubit>>(inputQubits), Microsoft__Quantum__Arrays__Tail.Apply<Qubit>(inputQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Intrinsic__Z = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.Z));
            this.Microsoft__Quantum__Arrays__Most = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Arrays.Most<>));
            this.Microsoft__Quantum__Arrays__Tail = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Arrays.Tail<>));
        }

        public override IApplyData __DataIn__(IQArray<Qubit> data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> inputQubits)
        {
            return __m__.Run<ReflectAboutAllOnes, IQArray<Qubit>, QVoid>(inputQubits);
        }
    }

    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs", OperationFunctor.Body, 59, 66)]
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs", OperationFunctor.Adjoint, 59, 66)]
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs", OperationFunctor.Controlled, 59, 66)]
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs", OperationFunctor.ControlledAdjoint, 59, 66)]
    public partial class PrepareUniform : Unitary<IQArray<Qubit>>, ICallable
    {
        public PrepareUniform(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PrepareUniform";
        String ICallable.FullName => "Microsoft.Quantum.Samples.SimpleGrover.PrepareUniform";
        protected IUnitary Microsoft__Quantum__Canon__ApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> __Body__ => (__in__) =>
        {
            var inputQubits = __in__;
#line 60 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Canon__ApplyToEachCA.Apply((Microsoft__Quantum__Intrinsic__H, inputQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> __AdjointBody__ => (__in__) =>
        {
            var inputQubits = __in__;
#line 59 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Canon__ApplyToEachCA.Adjoint.Apply((Microsoft__Quantum__Intrinsic__H, inputQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> __ControlledBody__ => (__in__) =>
        {
            var (__controlQubits__,inputQubits) = __in__;
#line 59 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Canon__ApplyToEachCA.Controlled.Apply((__controlQubits__, (Microsoft__Quantum__Intrinsic__H, inputQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> __ControlledAdjointBody__ => (__in__) =>
        {
            var (__controlQubits__,inputQubits) = __in__;
#line 59 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Canon__ApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (Microsoft__Quantum__Intrinsic__H, inputQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Canon__ApplyToEachCA = this.__Factory__.Get<IUnitary>(typeof(global::Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __DataIn__(IQArray<Qubit> data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> inputQubits)
        {
            return __m__.Run<PrepareUniform, IQArray<Qubit>, QVoid>(inputQubits);
        }
    }

    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs", OperationFunctor.Body, 66, -1)]
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs", OperationFunctor.Adjoint, 66, -1)]
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs", OperationFunctor.Controlled, 66, -1)]
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs", OperationFunctor.ControlledAdjoint, 66, -1)]
    public partial class PrepareAllOnes : Unitary<IQArray<Qubit>>, ICallable
    {
        public PrepareAllOnes(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PrepareAllOnes";
        String ICallable.FullName => "Microsoft.Quantum.Samples.SimpleGrover.PrepareAllOnes";
        protected IUnitary Microsoft__Quantum__Canon__ApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> __Body__ => (__in__) =>
        {
            var inputQubits = __in__;
#line 67 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Canon__ApplyToEachCA.Apply((Microsoft__Quantum__Intrinsic__X, inputQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> __AdjointBody__ => (__in__) =>
        {
            var inputQubits = __in__;
#line 66 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Canon__ApplyToEachCA.Adjoint.Apply((Microsoft__Quantum__Intrinsic__X, inputQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> __ControlledBody__ => (__in__) =>
        {
            var (__controlQubits__,inputQubits) = __in__;
#line 66 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Canon__ApplyToEachCA.Controlled.Apply((__controlQubits__, (Microsoft__Quantum__Intrinsic__X, inputQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> __ControlledAdjointBody__ => (__in__) =>
        {
            var (__controlQubits__,inputQubits) = __in__;
#line 66 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\simple-grover\\Reflections.qs"
            Microsoft__Quantum__Canon__ApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (Microsoft__Quantum__Intrinsic__X, inputQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Canon__ApplyToEachCA = this.__Factory__.Get<IUnitary>(typeof(global::Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __DataIn__(IQArray<Qubit> data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> inputQubits)
        {
            return __m__.Run<PrepareAllOnes, IQArray<Qubit>, QVoid>(inputQubits);
        }
    }
}