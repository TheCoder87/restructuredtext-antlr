﻿namespace ReStructuredText
{
    public class InterpretedText : ITextArea
    {
        public string Title { get; }
        private readonly TextArea _textArea;

        public InterpretedText(string title, TextArea textArea)
        {
            Title = title;
            _textArea = textArea;
        }

        public bool IsIndented => _textArea.IsIndented;
        public Content Content => _textArea.Content;
        public int Indentation
        {
            get => _textArea.Indentation;
            set => _textArea.Indentation = value;
        }

        public bool IsQuoted => _textArea.IsQuoted;
        public ElementType TypeCode => ElementType.InterpretedText;
    }
}