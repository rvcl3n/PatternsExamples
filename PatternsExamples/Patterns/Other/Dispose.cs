using System;

namespace PatternsExamples.Patterns.Other
{
    class DisposeExample : IDisposable
    {
        private bool disposed = false;

        //IDisposable.
        public void Dispose()
        {
            Dispose(true);
            // disable finalization
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Free resources
                }
                // free unmanages objects
                disposed = true;
            }
        }

        // Destructor
        ~DisposeExample()
        {
            Dispose(false);
        }
    }
}