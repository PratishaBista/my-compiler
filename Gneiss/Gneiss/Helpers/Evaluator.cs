namespace Gneiss.Helpers

{

    class Evaluator
    {
        private readonly ExpressionSyntax _root;
        public Evaluator(ExpressionSyntax root)
        {
            this._root = root;
        }

        public int Evaluate()
        {
            return EvaluateExpression(_root);
        }

        private int EvaluateExpression(ExpressionSyntax node)
        {

            if (node is NumberExpressionSyntax n &&
      n.NumberToken.Value is int value)
            {
                return value;
            }

            if (node is BinaryExpressionSyntax binary)
            {
                var left = EvaluateExpression(binary.Left);
                var right = EvaluateExpression(binary.Right);

                return binary.OperatorToken.Kind switch
                {
                    SyntaxKind.StarToken => left * right,
                    SyntaxKind.PlusToken => left + right,
                    SyntaxKind.MinusToken => left - right,
                    SyntaxKind.SlashToken => left / right,
                    _ => throw new InvalidOperationException(
                        $"Unexpected operator: {binary.OperatorToken.Kind}")
                };
            }
            throw new InvalidOperationException($"Unexpected node: {node.Kind}");
        }
    }
}