import http.client
import os
import sys
import threading
import time
from urllib.parse import urlparse

class FileDownloader:
    def __init__(self, url):
        self.url = url
        self.parsed_url = urlparse(url)
        self.file_name = os.path.basename(self.parsed_url.path) or "downloaded_file"
        self.downloaded_bytes = 0
        self.last_downloaded_bytes = 0
        self.stop_event = threading.Event()

    def download_file(self):
        try:
            connection = http.client.HTTPConnection(self.parsed_url.netloc)
            connection.request("GET", self.parsed_url.path)
            response = connection.getresponse()

            if response.status != 200:
                print(f"HTTP Запрос не выполнен, код состояния: {response.status}")
                connection.close()
                return

            with open(self.file_name, 'wb') as f:
                while not self.stop_event.is_set():
                    chunk = response.read(1024)
                    if not chunk:
                        break
                    f.write(chunk)
                    self.downloaded_bytes += len(chunk)

            connection.close()
            print(f"\nЗагрузка завершена, и файл сохраняется как: {self.file_name}")
        except Exception as e:
            print(f"Загрузка не удалась: {e}")

    def display_progress(self):
        while not self.stop_event.is_set():
            current_downloaded = self.downloaded_bytes
            speed = current_downloaded - self.last_downloaded_bytes
            self.last_downloaded_bytes = current_downloaded
            print(f"Загрузок в секунду: {speed} байт, всего скачано: {current_downloaded} байт")
            time.sleep(1)

    def start(self):
        download_thread = threading.Thread(target=self.download_file)
        progress_thread = threading.Thread(target=self.display_progress)

        download_thread.start()
        progress_thread.start()

        try:
            download_thread.join()
        except KeyboardInterrupt:
            print("Загрузка прервана。")
            self.stop_event.set()

        self.stop_event.set()
        progress_thread.join()

if __name__ == "__main__":
    if len(sys.argv) != 2:
        print("python CESHI.py <http://releases.ubuntu.com/20.04/ubuntu-20.04.6-desktop-amd64.iso>")
        sys.exit(1)

    url = sys.argv[1]
    downloader = FileDownloader(url)
    downloader.start()
