
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Bond;
using Bond.IO.Unsafe;
using Bond.Protocols;

namespace Microsoft.Quantum.QsCompiler.BondSchemas
{
    using SimpleBinaryDeserializer = Deserializer<SimpleBinaryReader<InputBuffer>>;
    using SimpleBinarySerializer = Serializer<SimpleBinaryWriter<OutputBuffer>>;

    /// <summary>
    /// This class provides methods for serialization/deserialization of Q# compilation objects.
    /// </summary>
    public static class Protocols
    {

        public static SyntaxTree.
    }
}
