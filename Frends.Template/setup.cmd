@echo off

IF exist "../LICENSE" ( del "./LICENSE" && echo "../LICENSE" exists ) ELSE ( move "./LICENSE" ".." )

IF exist "../.github/workflows" ( echo "../.github/workflows" exists ) ELSE ( mkdir "../.github/workflows" && echo "../.github/workflows" created)

for /R "./workflows" %%f in (*) do (
	move /Y "%%f" "../.github/workflows"
)

echo "workflow files moved."

rmdir "./workflows"

del "setup.sh"

(goto) 2>nul & del "setup.cmd.bak" & del "%~f0"