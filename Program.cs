// See https://aka.ms/new-console-template for more information
using Google.Cloud.Storage.V1;

// 環境変数を設定する
// ref. https://cloud.google.com/docs/authentication/getting-started?hl=ja#setting_the_environment_variable
Environment.SetEnvironmentVariable(
            "GOOGLE_APPLICATION_CREDENTIALS",
            Path.Combine(AppContext.BaseDirectory, "wide-memento-xxxxxxxxx.json"));

// ローカルファイルのパス
var localPath = "";
// バケット名
var bucketName = "";
// ファイル名
var fileName = "";
var storage = StorageClient.Create();
using var fileStream = File.OpenRead(localPath);
storage.UploadObject(bucketName, fileName, null, fileStream);