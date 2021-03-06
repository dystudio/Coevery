using Coevery.Indexing;

namespace Coevery.ContentManagement.Handlers {
    public class IndexContentContext : ContentContextBase {

        public IDocumentIndex DocumentIndex { get; private set; }

        public IndexContentContext(ContentItem contentItem, IDocumentIndex documentIndex)
            : base(contentItem) {
            DocumentIndex = documentIndex;
        }
    }
}