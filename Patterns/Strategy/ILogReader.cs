/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 октября 2025 06:52:01
 * Version: 1.0.52
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
