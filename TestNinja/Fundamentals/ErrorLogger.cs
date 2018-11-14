
using System;

namespace TestNinja.Fundamentals {
    public class ErrorLogger {
        public string LastError { get; set; }

        public event EventHandler<Guid> ErrorLogged;

        private Guid _errorId;

        public void Log(string error) {
            if (String.IsNullOrWhiteSpace(error)) {
                // 1. Check if it's null
                // 2. Check if it's empty string
                // 3. Check if it's string but has a white space
                throw new ArgumentNullException();
            }

            // 3
            LastError = error;

            // Write the log to a storage
            // ...
            _errorId = Guid.NewGuid();
            OnErrorLogged();
        }

        protected virtual void OnErrorLogged() {
            // This is one of the implementation details;
            // This MUST NOT be public!
            //protected virtual void OnErrorLogged(Guid errorId) {
            ErrorLogged?.Invoke(this, _errorId);
        }
    }
}