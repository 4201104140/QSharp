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

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyDatabaseOracle\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":68}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Given a qubit to use to store a mark bit and a register corresponding\",\" to a database, marks the first qubit conditioned on the register\",\" state being the all-ones state |11…1〉.\",\"\",\" # Input\",\" ## markedQubit\",\" A qubit to be targeted by an `X` operation controlled on whether\",\" the state of `databaseRegister` corresponds to a market item.\",\" ## databaseRegister\",\" A register representing the target of a query to the database.\",\"\",\" # Remarks\",\" Implements the operation\",\"\",\"     |z〉 |k〉 ↦ |z ⊕ f(k)〉 |k〉,\",\"\",\" where f(k) = 1 if and only if k = 2^(Length(databaseRegister)) - 1 and\",\" 0 otherwise.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyDatabaseOracle\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyDatabaseOracle\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":90},\"Item2\":{\"Line\":1,\"Column\":99}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Microsoft.Quantum.Samples.DatabaseSearch.ApplyDatabaseOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyDatabaseOracle\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":90},\"Item2\":{\"Line\":1,\"Column\":99}},\"Documentation\":[\"automatically generated QsControlled specialization for Microsoft.Quantum.Samples.DatabaseSearch.ApplyDatabaseOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyDatabaseOracle\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":90},\"Item2\":{\"Line\":1,\"Column\":99}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Microsoft.Quantum.Samples.DatabaseSearch.ApplyDatabaseOracle\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyUniformSuperpositionOracle\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":59}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Given a register of qubits initially in the state |00…0〉, prepares\",\" a uniform superposition over all computational basis states.\",\"\",\" # Input\",\" ## databaseRegister\",\" A register of n qubits initially in the |00…0〉 state.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyUniformSuperpositionOracle\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyUniformSuperpositionOracle\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":81},\"Item2\":{\"Line\":1,\"Column\":90}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Microsoft.Quantum.Samples.DatabaseSearch.ApplyUniformSuperpositionOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyUniformSuperpositionOracle\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":81},\"Item2\":{\"Line\":1,\"Column\":90}},\"Documentation\":[\"automatically generated QsControlled specialization for Microsoft.Quantum.Samples.DatabaseSearch.ApplyUniformSuperpositionOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyUniformSuperpositionOracle\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":81},\"Item2\":{\"Line\":1,\"Column\":90}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Microsoft.Quantum.Samples.DatabaseSearch.ApplyUniformSuperpositionOracle\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyStatePreparationOracle\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":98,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":51}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"databaseRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":77}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyStatePreparationOracle\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":98,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyStatePreparationOracle\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":98,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":99},\"Item2\":{\"Line\":1,\"Column\":108}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Microsoft.Quantum.Samples.DatabaseSearch.ApplyStatePreparationOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyStatePreparationOracle\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":98,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":99},\"Item2\":{\"Line\":1,\"Column\":108}},\"Documentation\":[\"automatically generated QsControlled specialization for Microsoft.Quantum.Samples.DatabaseSearch.ApplyStatePreparationOracle\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ApplyStatePreparationOracle\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":98,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":99},\"Item2\":{\"Line\":1,\"Column\":108}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Microsoft.Quantum.Samples.DatabaseSearch.ApplyStatePreparationOracle\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ReflectAboutMarkedState\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":103,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markedQubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Microsoft.Quantum.Samples.DatabaseSearch\",\"Name\":\"ReflectAboutMarkedState\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\phant\\\\OneDrive\\\\Desktop\\\\PhnTnTi\\\\QSharp\\\\samples\\\\algorithms\\\\DatabaseSearchSample\\\\DatabaseSearch.qs\",\"Position\":{\"Item1\":103,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
#line hidden
namespace Microsoft.Quantum.Samples.DatabaseSearch
{
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs", OperationFunctor.Body, 62, 95)]
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs", OperationFunctor.Adjoint, 62, 95)]
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs", OperationFunctor.Controlled, 62, 95)]
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs", OperationFunctor.ControlledAdjoint, 62, 95)]
    public partial class ApplyDatabaseOracle : Unitary<(Qubit,IQArray<Qubit>)>, ICallable
    {
        public ApplyDatabaseOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,IQArray<Qubit>)>, IApplyData
        {
            public In((Qubit,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    return Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
                }
            }
        }

        String ICallable.Name => "ApplyDatabaseOracle";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ApplyDatabaseOracle";
        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        public override Func<(Qubit,IQArray<Qubit>), QVoid> __Body__ => (__in__) =>
        {
            var (markedQubit,databaseRegister) = __in__;
#line 66 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            Microsoft__Quantum__Intrinsic__X.Controlled.Apply((databaseRegister, markedQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,IQArray<Qubit>), QVoid> __AdjointBody__ => (__in__) =>
        {
            var (markedQubit,databaseRegister) = __in__;
#line 62 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            Microsoft__Quantum__Intrinsic__X.Controlled.Adjoint.Apply((databaseRegister, markedQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Qubit,IQArray<Qubit>)), QVoid> __ControlledBody__ => (__in__) =>
        {
            var (__controlQubits__,(markedQubit,databaseRegister)) = __in__;
#line 62 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            Microsoft__Quantum__Intrinsic__X.Controlled.Controlled.Apply((__controlQubits__, (databaseRegister, markedQubit)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Qubit,IQArray<Qubit>)), QVoid> __ControlledAdjointBody__ => (__in__) =>
        {
            var (__controlQubits__,(markedQubit,databaseRegister)) = __in__;
#line 62 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            Microsoft__Quantum__Intrinsic__X.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (databaseRegister, markedQubit)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __DataIn__((Qubit,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit, IQArray<Qubit> databaseRegister)
        {
            return __m__.Run<ApplyDatabaseOracle, (Qubit,IQArray<Qubit>), QVoid>((markedQubit, databaseRegister));
        }
    }

    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs", OperationFunctor.Body, 95, 99)]
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs", OperationFunctor.Adjoint, 95, 99)]
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs", OperationFunctor.Controlled, 95, 99)]
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs", OperationFunctor.ControlledAdjoint, 95, 99)]
    public partial class ApplyUniformSuperpositionOracle : Unitary<IQArray<Qubit>>, ICallable
    {
        public ApplyUniformSuperpositionOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ApplyUniformSuperpositionOracle";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ApplyUniformSuperpositionOracle";
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
            var databaseRegister = __in__;
#line 96 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            Microsoft__Quantum__Canon__ApplyToEachCA.Apply((Microsoft__Quantum__Intrinsic__H, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> __AdjointBody__ => (__in__) =>
        {
            var databaseRegister = __in__;
#line 95 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            Microsoft__Quantum__Canon__ApplyToEachCA.Adjoint.Apply((Microsoft__Quantum__Intrinsic__H, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> __ControlledBody__ => (__in__) =>
        {
            var (__controlQubits__,databaseRegister) = __in__;
#line 95 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            Microsoft__Quantum__Canon__ApplyToEachCA.Controlled.Apply((__controlQubits__, (Microsoft__Quantum__Intrinsic__H, databaseRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> __ControlledAdjointBody__ => (__in__) =>
        {
            var (__controlQubits__,databaseRegister) = __in__;
#line 95 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            Microsoft__Quantum__Canon__ApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (Microsoft__Quantum__Intrinsic__H, databaseRegister)));
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
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> databaseRegister)
        {
            return __m__.Run<ApplyUniformSuperpositionOracle, IQArray<Qubit>, QVoid>(databaseRegister);
        }
    }

    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs", OperationFunctor.Body, 99, 104)]
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs", OperationFunctor.Adjoint, 99, 104)]
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs", OperationFunctor.Controlled, 99, 104)]
    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs", OperationFunctor.ControlledAdjoint, 99, 104)]
    public partial class ApplyStatePreparationOracle : Unitary<(Qubit,IQArray<Qubit>)>, ICallable
    {
        public ApplyStatePreparationOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,IQArray<Qubit>)>, IApplyData
        {
            public In((Qubit,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    return Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
                }
            }
        }

        String ICallable.Name => "ApplyStatePreparationOracle";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ApplyStatePreparationOracle";
        protected IUnitary<IQArray<Qubit>> ApplyUniformSuperpositionOracle__
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,IQArray<Qubit>)> ApplyDatabaseOracle__
        {
            get;
            set;
        }

        public override Func<(Qubit,IQArray<Qubit>), QVoid> __Body__ => (__in__) =>
        {
            var (markedQubit,databaseRegister) = __in__;
#line 100 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            ApplyUniformSuperpositionOracle__.Apply(databaseRegister);
#line 101 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            ApplyDatabaseOracle__.Apply((markedQubit, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,IQArray<Qubit>), QVoid> __AdjointBody__ => (__in__) =>
        {
            var (markedQubit,databaseRegister) = __in__;
#line 99 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            ApplyDatabaseOracle__.Adjoint.Apply((markedQubit, databaseRegister));
#line 99 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            ApplyUniformSuperpositionOracle__.Adjoint.Apply(databaseRegister);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Qubit,IQArray<Qubit>)), QVoid> __ControlledBody__ => (__in__) =>
        {
            var (__controlQubits__,(markedQubit,databaseRegister)) = __in__;
#line 99 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            ApplyUniformSuperpositionOracle__.Controlled.Apply((__controlQubits__, databaseRegister));
#line 99 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            ApplyDatabaseOracle__.Controlled.Apply((__controlQubits__, (markedQubit, databaseRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Qubit,IQArray<Qubit>)), QVoid> __ControlledAdjointBody__ => (__in__) =>
        {
            var (__controlQubits__,(markedQubit,databaseRegister)) = __in__;
#line 99 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            ApplyDatabaseOracle__.Adjoint.Controlled.Apply((__controlQubits__, (markedQubit, databaseRegister)));
#line 99 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            ApplyUniformSuperpositionOracle__.Adjoint.Controlled.Apply((__controlQubits__, databaseRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.ApplyUniformSuperpositionOracle__ = this.__Factory__.Get<IUnitary<IQArray<Qubit>>>(typeof(ApplyUniformSuperpositionOracle));
            this.ApplyDatabaseOracle__ = this.__Factory__.Get<IUnitary<(Qubit,IQArray<Qubit>)>>(typeof(ApplyDatabaseOracle));
        }

        public override IApplyData __DataIn__((Qubit,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit, IQArray<Qubit> databaseRegister)
        {
            return __m__.Run<ApplyStatePreparationOracle, (Qubit,IQArray<Qubit>), QVoid>((markedQubit, databaseRegister));
        }
    }

    [SourceLocation("C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs", OperationFunctor.Body, 104, -1)]
    public partial class ReflectAboutMarkedState : Operation<Qubit, QVoid>, ICallable
    {
        public ReflectAboutMarkedState(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectAboutMarkedState";
        String ICallable.FullName => "Microsoft.Quantum.Samples.DatabaseSearch.ReflectAboutMarkedState";
        protected IUnitary<(Double,Qubit)> Microsoft__Quantum__Intrinsic__R1
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> Microsoft__Quantum__Math__PI
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> __Body__ => (__in__) =>
        {
            var markedQubit = __in__;
#line 106 "C:\\Users\\phant\\OneDrive\\Desktop\\PhnTnTi\\QSharp\\samples\\algorithms\\DatabaseSearchSample\\DatabaseSearch.qs"
            Microsoft__Quantum__Intrinsic__R1.Apply((Microsoft__Quantum__Math__PI.Apply(QVoid.Instance), markedQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Intrinsic__R1 = this.__Factory__.Get<IUnitary<(Double,Qubit)>>(typeof(global::Microsoft.Quantum.Intrinsic.R1));
            this.Microsoft__Quantum__Math__PI = this.__Factory__.Get<ICallable<QVoid, Double>>(typeof(global::Microsoft.Quantum.Math.PI));
        }

        public override IApplyData __DataIn__(Qubit data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit markedQubit)
        {
            return __m__.Run<ReflectAboutMarkedState, Qubit, QVoid>(markedQubit);
        }
    }
}