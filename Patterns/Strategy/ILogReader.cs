/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 марта 2026 06:52:05
 * Version: 1.0.202
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
