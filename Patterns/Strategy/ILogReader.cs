/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 октября 2025 11:18:49
 * Version: 1.0.64
 */

namespace Strategy;

internal interface ILogReader
{
    List<LogEntry> Read();
}
