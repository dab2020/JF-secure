from cx_Freeze import setup, Executable

base = None    

executables = [Executable("domain chooser.py", base=base)]

packages = ["idna"]
options = {
    'build_exe': {    
        'packages':packages,
    },    
}

setup(
    name = "JF-secure domain chooser",
    options = options,
    version = "2.0",
    description = 'Chooses Domians',
    executables = executables
)