/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 октября 2025 13:46:38
 * Version: 1.0.66
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
