**System.IO**
***
1. File, FileInfo
2. Directory, DirectoryInfo
3. Path



**1. File, FileInfo**
***
Provides METHODS for Creating, Copying, Deleting, Moving, and Opening of files.

***FileInfo***: provides **INSTANCE METHODS**
***File***: provides **STATIC METHODS**

**File,FileInfo Listed Methods**
1. Create()
2. Copy()
3. Delete()
4. Exists()
5. GetAttributes()
6. Move()
7. ReadAllText()

**2. Directory, DirectoryInfo**


***DirectoryInfo***: provides **INSTANCE METHODS**
***Directory***: provides **STATIC METHODS**

**Directory,DirectoryInfo Listed Methods**
1. CreateDirectory()
2. Delete()
3. Exists()
4. Move()
5. GetFiles() // Get files in diretory. Filter method can be applied, such as, files with EXE extension.
6. GetCurrentDirectory()  // Tells where application is residing
7. GetLogicalDrives() //C Drive, D Drive...


**3. Path**
Provides Methods to work wtih a string that contains a file or directory.

**Path METHODS**
1. GetDirectoryName()
2. GetFileName()
3. GetExtension()
4. GetTempPath()  // path of the current users temporary folder

***DirectoryInfo***: provides **INSTANCE METHODS**
***Directory***: provides **STATIC METHODS**