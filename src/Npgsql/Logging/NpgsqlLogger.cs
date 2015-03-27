﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Npgsql.Logging
{
    /// <summary>
    /// A generic interface for logging.
    /// </summary>
    public abstract class NpgsqlLogger
    {
        public abstract bool IsEnabled(NpgsqlLogLevel level);
        public abstract void Log(NpgsqlLogLevel level, int connectorId, string msg, Exception exception = null);

        internal void Trace(string msg, int connectionId = 0) { Log(NpgsqlLogLevel.Trace, connectionId, msg); }
        internal void Debug(string msg, int connectionId = 0) { Log(NpgsqlLogLevel.Debug, connectionId, msg); }
        internal void Info(string msg,  int connectionId = 0) { Log(NpgsqlLogLevel.Info,  connectionId, msg); }
        internal void Warn(string msg,  int connectionId = 0) { Log(NpgsqlLogLevel.Warn,  connectionId, msg); }
        internal void Error(string msg, int connectionId = 0) { Log(NpgsqlLogLevel.Error, connectionId, msg); }
        internal void Fatal(string msg, int connectionId = 0) { Log(NpgsqlLogLevel.Fatal, connectionId, msg); }

        /*
        internal void Trace(string msg, int connectionId = 0, params object[] args) { Log(NpgsqlLogLevel.Trace, String.Format(msg, args)); }
        internal void Debug(string msg, params object[] args) { Log(NpgsqlLogLevel.Debug, String.Format(msg, args)); }
        internal void Info(string msg,  params object[] args) { Log(NpgsqlLogLevel.Info,  String.Format(msg, args)); }
        internal void Warn(string msg,  params object[] args) { Log(NpgsqlLogLevel.Warn,  String.Format(msg, args)); }
        internal void Error(string msg, params object[] args) { Log(NpgsqlLogLevel.Error, String.Format(msg, args)); }
        internal void Fatal(string msg, params object[] args) { Log(NpgsqlLogLevel.Fatal, String.Format(msg, args)); }
         */

        internal void Trace(string msg, Exception ex, int connectionId = 0) { Log(NpgsqlLogLevel.Trace, connectionId, msg, ex); }
        internal void Debug(string msg, Exception ex, int connectionId = 0) { Log(NpgsqlLogLevel.Debug, connectionId, msg, ex); }
        internal void Info(string msg,  Exception ex, int connectionId = 0) { Log(NpgsqlLogLevel.Info,  connectionId, msg, ex); }
        internal void Warn(string msg,  Exception ex, int connectionId = 0) { Log(NpgsqlLogLevel.Warn,  connectionId, msg, ex); }
        internal void Error(string msg, Exception ex, int connectionId = 0) { Log(NpgsqlLogLevel.Error, connectionId, msg, ex); }
        internal void Fatal(string msg, Exception ex, int connectionId = 0) { Log(NpgsqlLogLevel.Fatal, connectionId, msg, ex); }
    }
}
