/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 ноября 2025 12:22:02
 * Version: 1.0.95
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
