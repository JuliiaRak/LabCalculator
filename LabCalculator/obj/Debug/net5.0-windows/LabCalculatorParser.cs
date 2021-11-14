﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from \\Mac\Home\Desktop\LabCalculator\LabCalculator\LabCalculator.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace LabCalculator {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class LabCalculatorParser : Parser {
	public const int
		NUMBER=1, IDENTIFIER=2, INT=3, EXPONENT=4, MULTIPLY=5, DIVIDE=6, SUBTRACT=7, 
		ADD=8, LPAREN=9, RPAREN=10, COMMA=11, DIV=12, MOD=13, INC=14, DEC=15, 
		WS=16, SUBSTRACT=17;
	public const int
		RULE_compileUnit = 0, RULE_expression = 1;
	public static readonly string[] ruleNames = {
		"compileUnit", "expression"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, null, "'^'", "'*'", "'/'", "'-'", "'+'", "'('", "')'", 
		"','", "'div'", "'mod'", "'inc'", "'dec'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "NUMBER", "IDENTIFIER", "INT", "EXPONENT", "MULTIPLY", "DIVIDE", 
		"SUBTRACT", "ADD", "LPAREN", "RPAREN", "COMMA", "DIV", "MOD", "INC", "DEC", 
		"WS", "SUBSTRACT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "LabCalculator.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public LabCalculatorParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class CompileUnitContext : ParserRuleContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(LabCalculatorParser.Eof, 0); }
		public CompileUnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compileUnit; } }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterCompileUnit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitCompileUnit(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCompileUnit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CompileUnitContext compileUnit() {
		CompileUnitContext _localctx = new CompileUnitContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_compileUnit);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 4; expression(0);
			State = 5; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ParenthesizedExprContext : ExpressionContext {
		public ITerminalNode LPAREN() { return GetToken(LabCalculatorParser.LPAREN, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(LabCalculatorParser.RPAREN, 0); }
		public ParenthesizedExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterParenthesizedExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitParenthesizedExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParenthesizedExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ExponentialExprContext : ExpressionContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode EXPONENT() { return GetToken(LabCalculatorParser.EXPONENT, 0); }
		public ExponentialExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterExponentialExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitExponentialExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExponentialExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MultiplicativeExprContext : ExpressionContext {
		public IToken operatorToken;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode MULTIPLY() { return GetToken(LabCalculatorParser.MULTIPLY, 0); }
		public ITerminalNode DIVIDE() { return GetToken(LabCalculatorParser.DIVIDE, 0); }
		public MultiplicativeExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterMultiplicativeExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitMultiplicativeExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMultiplicativeExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AdditiveExprContext : ExpressionContext {
		public IToken operatorToken;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode ADD() { return GetToken(LabCalculatorParser.ADD, 0); }
		public ITerminalNode SUBTRACT() { return GetToken(LabCalculatorParser.SUBTRACT, 0); }
		public AdditiveExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterAdditiveExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitAdditiveExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAdditiveExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ModDivExprContext : ExpressionContext {
		public IToken operatorToken;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode DIV() { return GetToken(LabCalculatorParser.DIV, 0); }
		public ITerminalNode MOD() { return GetToken(LabCalculatorParser.MOD, 0); }
		public ModDivExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterModDivExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitModDivExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitModDivExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class UnarExprContext : ExpressionContext {
		public ITerminalNode SUBSTRACT() { return GetToken(LabCalculatorParser.SUBSTRACT, 0); }
		public ITerminalNode LPAREN() { return GetToken(LabCalculatorParser.LPAREN, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(LabCalculatorParser.RPAREN, 0); }
		public UnarExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterUnarExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitUnarExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUnarExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BigExprContext : ExpressionContext {
		public IToken tokenOperator;
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode NUMBER() { return GetToken(LabCalculatorParser.NUMBER, 0); }
		public ITerminalNode COMMA() { return GetToken(LabCalculatorParser.COMMA, 0); }
		public BigExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterBigExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitBigExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBigExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IncExprContext : ExpressionContext {
		public ITerminalNode INC() { return GetToken(LabCalculatorParser.INC, 0); }
		public ITerminalNode LPAREN() { return GetToken(LabCalculatorParser.LPAREN, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(LabCalculatorParser.RPAREN, 0); }
		public IncExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterIncExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitIncExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIncExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DecExprContext : ExpressionContext {
		public ITerminalNode DEC() { return GetToken(LabCalculatorParser.DEC, 0); }
		public ITerminalNode LPAREN() { return GetToken(LabCalculatorParser.LPAREN, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(LabCalculatorParser.RPAREN, 0); }
		public DecExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterDecExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitDecExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDecExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NumberExprContext : ExpressionContext {
		public ITerminalNode NUMBER() { return GetToken(LabCalculatorParser.NUMBER, 0); }
		public NumberExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterNumberExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitNumberExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumberExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IdentifierExprContext : ExpressionContext {
		public ITerminalNode IDENTIFIER() { return GetToken(LabCalculatorParser.IDENTIFIER, 0); }
		public IdentifierExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.EnterIdentifierExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ILabCalculatorListener typedListener = listener as ILabCalculatorListener;
			if (typedListener != null) typedListener.ExitIdentifierExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ILabCalculatorVisitor<TResult> typedVisitor = visitor as ILabCalculatorVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdentifierExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(_ctx, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 31;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,0,_ctx) ) {
			case 1:
				{
				_localctx = new ParenthesizedExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				State = 8; Match(LPAREN);
				State = 9; expression(0);
				State = 10; Match(RPAREN);
				}
				break;

			case 2:
				{
				_localctx = new UnarExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 12; Match(SUBSTRACT);
				State = 13; Match(LPAREN);
				State = 14; expression(0);
				State = 15; Match(RPAREN);
				}
				break;

			case 3:
				{
				_localctx = new BigExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 17;
				((BigExprContext)_localctx).tokenOperator = _input.Lt(1);
				_la = _input.La(1);
				if ( !(_la==NUMBER || _la==COMMA) ) {
					((BigExprContext)_localctx).tokenOperator = _errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 18; expression(5);
				}
				break;

			case 4:
				{
				_localctx = new IncExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 19; Match(INC);
				State = 20; Match(LPAREN);
				State = 21; expression(0);
				State = 22; Match(RPAREN);
				}
				break;

			case 5:
				{
				_localctx = new DecExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 24; Match(DEC);
				State = 25; Match(LPAREN);
				State = 26; expression(0);
				State = 27; Match(RPAREN);
				}
				break;

			case 6:
				{
				_localctx = new NumberExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 29; Match(NUMBER);
				}
				break;

			case 7:
				{
				_localctx = new IdentifierExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 30; Match(IDENTIFIER);
				}
				break;
			}
			_ctx.stop = _input.Lt(-1);
			State = 47;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,2,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 45;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,1,_ctx) ) {
					case 1:
						{
						_localctx = new ExponentialExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 33;
						if (!(Precpred(_ctx, 10))) throw new FailedPredicateException(this, "Precpred(_ctx, 10)");
						State = 34; Match(EXPONENT);
						State = 35; expression(11);
						}
						break;

					case 2:
						{
						_localctx = new MultiplicativeExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 36;
						if (!(Precpred(_ctx, 9))) throw new FailedPredicateException(this, "Precpred(_ctx, 9)");
						State = 37;
						((MultiplicativeExprContext)_localctx).operatorToken = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==MULTIPLY || _la==DIVIDE) ) {
							((MultiplicativeExprContext)_localctx).operatorToken = _errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						State = 38; expression(10);
						}
						break;

					case 3:
						{
						_localctx = new AdditiveExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 39;
						if (!(Precpred(_ctx, 8))) throw new FailedPredicateException(this, "Precpred(_ctx, 8)");
						State = 40;
						((AdditiveExprContext)_localctx).operatorToken = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==SUBTRACT || _la==ADD) ) {
							((AdditiveExprContext)_localctx).operatorToken = _errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						State = 41; expression(9);
						}
						break;

					case 4:
						{
						_localctx = new ModDivExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 42;
						if (!(Precpred(_ctx, 7))) throw new FailedPredicateException(this, "Precpred(_ctx, 7)");
						State = 43;
						((ModDivExprContext)_localctx).operatorToken = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==DIV || _la==MOD) ) {
							((ModDivExprContext)_localctx).operatorToken = _errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						State = 44; expression(8);
						}
						break;
					}
					} 
				}
				State = 49;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,2,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 1: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(_ctx, 10);

		case 1: return Precpred(_ctx, 9);

		case 2: return Precpred(_ctx, 8);

		case 3: return Precpred(_ctx, 7);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x13\x35\x4\x2\t"+
		"\x2\x4\x3\t\x3\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x5\x3\"\n\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\a\x3\x30\n\x3\f\x3"+
		"\xE\x3\x33\v\x3\x3\x3\x2\x2\x3\x4\x4\x2\x2\x4\x2\x2\x6\x4\x2\x3\x3\r\r"+
		"\x3\x2\a\b\x3\x2\t\n\x3\x2\xE\xF<\x2\x6\x3\x2\x2\x2\x4!\x3\x2\x2\x2\x6"+
		"\a\x5\x4\x3\x2\a\b\a\x2\x2\x3\b\x3\x3\x2\x2\x2\t\n\b\x3\x1\x2\n\v\a\v"+
		"\x2\x2\v\f\x5\x4\x3\x2\f\r\a\f\x2\x2\r\"\x3\x2\x2\x2\xE\xF\a\x13\x2\x2"+
		"\xF\x10\a\v\x2\x2\x10\x11\x5\x4\x3\x2\x11\x12\a\f\x2\x2\x12\"\x3\x2\x2"+
		"\x2\x13\x14\t\x2\x2\x2\x14\"\x5\x4\x3\a\x15\x16\a\x10\x2\x2\x16\x17\a"+
		"\v\x2\x2\x17\x18\x5\x4\x3\x2\x18\x19\a\f\x2\x2\x19\"\x3\x2\x2\x2\x1A\x1B"+
		"\a\x11\x2\x2\x1B\x1C\a\v\x2\x2\x1C\x1D\x5\x4\x3\x2\x1D\x1E\a\f\x2\x2\x1E"+
		"\"\x3\x2\x2\x2\x1F\"\a\x3\x2\x2 \"\a\x4\x2\x2!\t\x3\x2\x2\x2!\xE\x3\x2"+
		"\x2\x2!\x13\x3\x2\x2\x2!\x15\x3\x2\x2\x2!\x1A\x3\x2\x2\x2!\x1F\x3\x2\x2"+
		"\x2! \x3\x2\x2\x2\"\x31\x3\x2\x2\x2#$\f\f\x2\x2$%\a\x6\x2\x2%\x30\x5\x4"+
		"\x3\r&\'\f\v\x2\x2\'(\t\x3\x2\x2(\x30\x5\x4\x3\f)*\f\n\x2\x2*+\t\x4\x2"+
		"\x2+\x30\x5\x4\x3\v,-\f\t\x2\x2-.\t\x5\x2\x2.\x30\x5\x4\x3\n/#\x3\x2\x2"+
		"\x2/&\x3\x2\x2\x2/)\x3\x2\x2\x2/,\x3\x2\x2\x2\x30\x33\x3\x2\x2\x2\x31"+
		"/\x3\x2\x2\x2\x31\x32\x3\x2\x2\x2\x32\x5\x3\x2\x2\x2\x33\x31\x3\x2\x2"+
		"\x2\x5!/\x31";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace LabCalculator