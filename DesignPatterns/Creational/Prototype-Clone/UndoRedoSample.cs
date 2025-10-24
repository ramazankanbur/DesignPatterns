using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype_Clone
{
    public class Document
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public List<string> Tags { get; set; } = new List<string>();

        public Document Clone()
        {
            return new Document
            {
                Title = this.Title,
                Body = this.Body,
                Tags = new List<string>(this.Tags)
            };
        }

        public override string ToString()
        {
            return $"Title: {Title}\nBody: {Body}\nTags: [{string.Join(", ", Tags)}]\n";
        }
    }

    public class VersionManager
    {
        private readonly List<Document> _history = new List<Document>();
        private int _currentIndex = -1;

        public Document Current => _currentIndex >= 0 ? _history[_currentIndex].Clone() : null;

        public void Save(Document doc)
        {
            if (doc == null) throw new ArgumentNullException(nameof(doc));

            if (_currentIndex < _history.Count - 1)
            {
                _history.RemoveRange(_currentIndex + 1, _history.Count - _currentIndex - 1);
            }

            _history.Add(doc.Clone()); 
            _currentIndex = _history.Count - 1;
        }

        public bool CanUndo => _currentIndex > 0;
        public bool CanRedo => _currentIndex < _history.Count - 1;

        public Document Undo()
        {
            if (!CanUndo) return null;
            _currentIndex--;
            return _history[_currentIndex].Clone();
        }

        public Document Redo()
        {
            if (!CanRedo) return null;
            _currentIndex++;
            return _history[_currentIndex].Clone();
        }

        public void PrintHistory()
        {
            Console.WriteLine("=== History ===");
            for (int i = 0; i < _history.Count; i++)
            {
                Console.WriteLine($"{(i == _currentIndex ? "-> " : "   ")}Version {i}: {_history[i].Title}");
            }
            Console.WriteLine("================");
        }
    }

}
