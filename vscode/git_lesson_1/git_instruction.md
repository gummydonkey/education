# Инструкция по работе с системой <!---# заголовок-->

## Что такое Git <!---# маленький заголовок-->

Гит это система контроля версий. Нужна для того чтобы не запутаться в изменениях файлов и не копить сотни копий одного и того же файла.
## Знакомимся с Git

Данные команды позволяют при последующих сохранениях файлов указывать кто их изменял.

    git config --global user.name “Your Name”
    git config --global user.email “forexample@email.com”
    ## Создание репозитория

Создание репозитория в папке, изменения файлов которой планируется отслеживать.

    git init


## Добавление файла для индексации

    git add example.txt
При этом если заменить название файла точкой

    git add .
Добавятся все файлы в которых были произведены изменения.


## Отслеживание файла

Создает слепок файлов проиндексированных командой git add 

    git commit
Используется в сочетании с "флагами":

    git commit -m "comment" - Добавление комментария.

    git commit -am "comment" - Сочетает в себе git add и добавление коментария.
    ## Проверка состояния репозитория
Команда для проверки состояние репозитория

    git status

## Просмотрт истории коммитов
Просмотр истории изменений коммитов

    git log
Для просмотра краткого содержания лога коммитов используется команда

    git log --oneline
Для просмотра лога всех коммитов (не зависимо от текущего активного) используем следующую команду

    git log --all

## Переключение между сохраненными версиями файла
Переключение между версиями осуществляется командой

    git checkoout "hash"
hash указывается в логах коммитов

## Просмотр различий между коммитами
Для просмотра отличий между двумя конкретными коммитами используем

    git diff "hash1" "hash2"
Если ввести команду без указания конкретных коммитов, будет показана разница между текущим и последним

    git diff

# Ветвление

## Создание и просмотр ветвлений

Для создания ветвления применяется команда

    git branch "NameBranch"
где "NameBranch" уникальное имя для новой ветви.

Для просмотра всех ветвлений так же используется команда

    git branch
но уже самостоятельно.

Так же для удаления веточки пользуемся командой с добавлением флага 
   
    git branch -d

## Объединение ветвлений

Для объединения ветвлений используется команда 

    git merge

## Переход между ветвления и коммитами

Переход осуществляется при помощи

    git checkout "Name/hash"
где "Name/hash" имя ветвления или хэш коммита получнный командой git status

<!--- понимаю команды не все хотя бы из тех что мы прошли но мне жена нашла вторую работу и я тупо не успеваю