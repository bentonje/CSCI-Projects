SDIR = ./src
CPC=g++
CC=gcc

BDIR = ./build
PDIR = ./psrc
TDIR = ./test

CFLAGS= -Wall -ggdb -I$(SDIR) -fPIC 
CPFLAGS= -Wall -ggdb -I$(SDIR) -fPIC 

DEPS = $(SDIR)/main_exe.c
TOBJ = $(BDIR)/main_exe.o
MOBJ = $(BDIR)/main_exe.o

$(BDIR)/%.o: $(SDIR)/%.c $(DEPS)
	$(MKDIR_P) $(dir $@)
	$(CC) -c -o $@ $< $(CFLAGS)

$(BDIR)/%.o: $(TDIR)/%.cpp $(DEPS)
	$(MKDIR_P) $(dir $@)
	$(CPC) -c -o $@ $< $(CPFLAGS)

$(BDIR)/test_executable: $(TOBJ)
	$(CPC) $(TOBJ) -g -pthread $(GSL_LIBS) -lgtest_main -lgtest -o $(BDIR)/test_executable

$(BDIR)/main_exe: $(MOBJ)
	$(CC) $(MOBJ) $(GSL_LIBS) -lm -o $(BDIR)/main_exe

test: $(BDIR)/test_executable
	$(BDIR)/test_executable --gtest_print_time=0

vtest: $(BDIR)/test_executable
	valgrind --leak-check=full $(BDIR)/test_executable --gtest_print_time=0

main: $(BDIR)/main_exe
	$(BDIR)/main_exe

.PHONY: clean

clean:
	rm -rf $(BDIR) *~ core $(SDIR)/*~ *.so psrc/cimpl.c $(PDIR)/*~ $(PDIR)/static/*~ $(PDIR)/templates/*~

py:$(OBJS) $(PSRCS) $(TOBJ)
	python3 psrc/setup.py build_ext -i

py_install:$(TOBJ) $(PSRCS) py
	python3 psrc/setup.py install

submit: 
	git commit -m "final submission" -a
	git push

MKDIR_P ?= mkdir -p
