#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


// InputAxisState
struct InputAxisState_t3530637542;
// ButtonState
struct ButtonState_t4192339040;
// GenericWindow
struct GenericWindow_t1006240903;

#include "mscorlib_System_Array2840145358.h"
#include "AssemblyU2DCSharp_Buttons1906005857.h"
#include "AssemblyU2DCSharp_InputAxisState3530637542.h"
#include "AssemblyU2DCSharp_ButtonState4192339039.h"
#include "AssemblyU2DCSharp_GenericWindow1006240903.h"

#pragma once
// Buttons[]
struct ButtonsU5BU5D_t1843995132  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) int32_t m_Items[1];

public:
	inline int32_t GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline int32_t* GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, int32_t value)
	{
		m_Items[index] = value;
	}
};
// InputAxisState[]
struct InputAxisStateU5BU5D_t982520003  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) InputAxisState_t3530637542 * m_Items[1];

public:
	inline InputAxisState_t3530637542 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline InputAxisState_t3530637542 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, InputAxisState_t3530637542 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
// ButtonState[]
struct ButtonStateU5BU5D_t1944312647  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) ButtonState_t4192339040 * m_Items[1];

public:
	inline ButtonState_t4192339040 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline ButtonState_t4192339040 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, ButtonState_t4192339040 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
// GenericWindow[]
struct GenericWindowU5BU5D_t3046460798  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) GenericWindow_t1006240903 * m_Items[1];

public:
	inline GenericWindow_t1006240903 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline GenericWindow_t1006240903 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, GenericWindow_t1006240903 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
