@echo off

for /r "./workflows" %%f in (*) do (
	move /Y "%%f" "../.github/workflows"
)
echo "workflow files moved."

rmdir "./workflows"

del %0
