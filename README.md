# WeChatExamV2

[![Pipeline](https://gitlab.aiursoft.com/aiursoft/wechatexamv2/badges/master/pipeline.svg)](https://gitlab.aiursoft.com/aiursoft/wechatexamv2/-/pipelines)
[![Coverage](https://gitlab.aiursoft.com/aiursoft/wechatexamv2/badges/master/coverage.svg)](https://gitlab.aiursoft.com/aiursoft/wechatexamv2/-/pipelines)

An independent starting point for the next version of WeChatExam, with the existing backend, administration UI, APIs and tests. Licensed under [MIT](LICENSE).

## Run locally

Requires .NET 10 SDK and Node.js.

```bash
npm ci --prefix src/Aiursoft.WeChatExamV2/wwwroot
npm run build --prefix src/Aiursoft.WeChatExamV2/wwwroot
dotnet run --project src/Aiursoft.WeChatExamV2 -- --urls http://localhost:5000
```

Open http://localhost:5000. The default local account is `admin@default.com` with password `Admin@123456!`.

SQLite is the default database. MySQL is also supported. Each provider starts with a new `init` migration for a fresh V2 database; these migrations do not upgrade a V1 database.

## Test

```bash
dotnet test Aiursoft.WeChatExamV2.sln
```
